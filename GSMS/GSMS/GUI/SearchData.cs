using GSMS.DL;
using GSMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS.GUI
{
    public partial class SearchData : Form
    {
        public event EventHandler ProductSelected;
        public event EventHandler ProductAddCart;

        public object SelectedProduct { get => display_GV.Rows[display_GV.SelectedCells[0].RowIndex].Cells["ProductName"].Value; }
        public object CartProduct { get => ITEM; }

        public object ITEM;

        private User user;

        public SearchData(User user)
        {
            InitializeComponent();
            display_GV.Visible = false;
            this.user = user;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_Txt.Text != null)
            {
                List<Products> list = ProductsDL.Search_Product(search_Txt.Text);

                if (list?.Count > 0)
                {
                    display_GV.DataSource = null;

                    if (user is Customer)
                    {
                        Cutomer_ProductsBinding(list);
                        DataGridViewButtonColumn button = Misc.GV_AddButton("Add", "Gv_Add_Btn");
                        display_GV.Columns.Add(button);
                        display_GV.CellContentClick += AddColumn_CellContentClick;
                    }
                    else if (user is Admin)
                    {
                        ProductsBinding(list);
                        DataGridViewButtonColumn button = Misc.GV_AddButton("Delete", "Gv_Del_Btn");
                        display_GV.Columns.Add(button);
                        display_GV.CellContentClick += DelColumn_CellContentClick;
                    }

                    display_GV.Visible = true;
                    display_GV.Refresh();
                }
                else
                {
                    MessageBox.Show("No Data Found !!!");
                }
            }
        }

        private void DelColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (display_GV.SelectedCells[0].ColumnIndex == display_GV.Columns["Gv_Del_btn"].Index)
            {
                int idx = display_GV.SelectedCells[0].RowIndex;

                object cellValue = display_GV.Rows[idx].Cells["ProductName"].Value;

                ProductsDL.RemoveinProductsList(ProductsDL.IsProductExists(cellValue.ToString()));
                UserDL.StoreUsersData();

                MessageBox.Show("Item Deleted !!!");
            }
        }

        private void AddColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (display_GV.SelectedCells[0].ColumnIndex == display_GV.Columns["Gv_Add_btn"].Index)
            {
                int idx = display_GV.SelectedCells[0].RowIndex;
                ITEM = display_GV.Rows[idx].Cells["ProductName"].Value;
                ProductAddCart?.Invoke(this, e);
            }
        }




        private void display_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSelected?.Invoke(this, e);
        }


        private void ProductsBinding(List<Products> list)
        {
            display_GV.DataSource = list.Select(c => new { c.ProductName, c.Price, c.Quantity, c.Sale }).ToList();
        }

        private void Cutomer_ProductsBinding(List<Products> list)
        {
            display_GV.DataSource = list.Select(c => new { c.ProductName, c.Price, c.Sale }).ToList();
        }



        // Validating Function

        private void search_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void search_Txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(search_Txt, string.Empty);
            if (!string.IsNullOrEmpty(search_Txt.Text.Trim()))
            {
                epSuccess.SetError(search_Txt, "Valid");
            }
            else
            {
                epSuccess.SetError(search_Txt, string.Empty);
            }
        }

        private void search_Txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(search_Txt.Text.Trim()))
            {
                epError.SetError(search_Txt, string.Empty);
            }
            else
            {
                epError.SetError(search_Txt, "Name is required.");
            }
        }
    }
}
