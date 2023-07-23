using GSMS.BL;
using GSMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS.GUI
{
    public partial class WatchProducts : Form
    {
        private User user = null;
        private List<Products> list = null;
        private int isCartItem = 0;

        public WatchProducts(List<Products> list)
        {
            this.list = list;
            InitializeComponent();
            Bill_TablePanel.Visible = false;
            ShowlowStock();
        }

        public WatchProducts(User user, List<Products> list)
        {
            this.user = user;
            this.list = list;
            InitializeComponent();
            Bill_TablePanel.Visible = false;
            DataBind();
        }

        public WatchProducts(User user, List<Products> list, int isCartItem)
        {
            this.user = user;
            this.list = list;
            this.isCartItem = isCartItem;
            
            InitializeComponent();

            if (isCartItem == 1)
            {
                Bill_TablePanel.Visible = false;
                Back_btn.Text = "Purchase";
            }

            DataBind();
        }



        private void DataBind()
        {
            GV.DataSource = null;

            if (user is Admin)
            {
                Bind();
                AddDelButton();
            }
            else if (user is Employee)
            {
                Bind();
            }
            else
            {
                if (isCartItem == 1)
                {
                    Bind();
                    AddCartDelButton();
                }
                else if (isCartItem == 2)
                {
                    Bind();
                }
                else
                {
                    Customer_P_View();
                }
            }

            GV.Refresh();
        }


        private void Bind()
        {
            GV.DataSource = list.Select(c => new { c.ProductName, c.Price, c.Quantity, c.Sale }).ToList();
        }
        private void Customer_P_View()
        {
            foreach (var o in list)
            {
                string Status = "In-Stock";

                if (o.GetProductQuantity() < o.GetProductThreshold())
                {
                    Status = "Out of Stock";
                }

                GV.DataSource = list.Select(c => new { c.ProductName, c.Price, c.Sale, Status }).ToList();
            }
        }


        private void AddDelButton()
        {
            DataGridViewButtonColumn button = Misc.GV_AddButton("Delete", "Gv_Del_Btn");
            GV.Columns.Add(button);
            GV.CellContentClick += GV_Del_CellContentClick;
        }
        private void GV_Del_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.SelectedCells[0].ColumnIndex == GV.Columns["Gv_Del_Btn"].Index)
            {

                int idx = GV.SelectedCells[0].RowIndex;
                object cellValue = GV.Rows[idx].Cells["ProductName"].Value;

                ProductsDL.RemoveinProductsList(ProductsDL.IsProductExists(cellValue.ToString()));
                ProductsDL.StoreProductsData();

                MessageBox.Show("Item Deleted !!!");
            }
        }


        private void AddCartDelButton()
        {
            DataGridViewButtonColumn button = Misc.GV_AddButton("Delete", "Gv_Del_Btn");
            GV.Columns.Add(button);
            GV.CellContentClick += GV_CartDel_CellContentClick;
        }
        private void GV_CartDel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.SelectedCells[0].ColumnIndex == GV.Columns["Gv_Del_Btn"].Index)
            {
                int idx = GV.SelectedCells[0].RowIndex;

                Customer cust = (Customer)user;

                cust.RemovefromCartList(ProductsDL.ReturnProduct((GV.Rows[idx].Cells["ProductName"].Value).ToString()));

                MessageBox.Show("Item Deleted !!!");
            }
        }



        private void ShowlowStock()
        {
            GV.DataSource = null;
            if (list.Count > 0)
            {
                foreach (var o in list)
                {
                    if (o.GetProductQuantity() < o.GetProductThreshold())
                    {
                        GV.DataSource = list.Select(c => new { c.ProductName, c.Price, c.Quantity, c.Sale }).ToList();
                    }
                }
                GV.Refresh();
            }
            else
            {
                MessageBox.Show("No Product Found");
                this.Close();
            }
        }



        public void SetBillTable(string line)
        {
            Bill_TablePanel.Visible = true;
            total_Bill_lbl.Text = line;
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (isCartItem == 1)
            {
                Customer cust = user as Customer;

                foreach (var x in list)
                {
                    ProductsDL.Minus_Quantity(x);
                }

                cust.Addin_Orders_placed_List(list);

                EmployeeDL.AddInOrderList(list);

                EmployeeDL.AddInCustomerList(UserDL.Return_Customer(UserDL.IsUserExists(user.GetName())));

                cust.ClearCartList();

                MessageBox.Show("Items are Purchased. You will shortly received the items !!!");
            }
            this.Hide();
        }

    }

}

