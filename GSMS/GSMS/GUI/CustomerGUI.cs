using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMS.BL;
using GSMS.DL;

namespace GSMS.GUI
{
    public partial class CustomerGUI : Form
    {
        private Customer _user;
        private Products item;
        public CustomerGUI(Customer user)
        {
            this._user = user;
            InitializeComponent();
            this.HideAllMenus();
            Misc.ShowUserData(userName_lbl, userContact_lbl, _user);
        }

        private void CustomerGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void HideAllMenus()
        {
            C_Products_Panel.Visible = false;
            C_Cart_Panel.Visible = false;
            C_Purchase_Panel.Visible = false;

            menu_Display_Panel.Controls.Clear();

        }

        private void ShowMenu(Panel p)
        {
            p.Visible = true;
        }

        private void C_LogOut_btn_Click(object sender, EventArgs e)
        {
            Misc.Logout(this);
        }



        // Products Details Button

        private void C_Products_Details_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            ShowMenu(C_Products_Panel);
        }

        // Watch Products

        private void C_WatchAll_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (ProductsDL.Inventory?.Count > 0)
            {
                WatchProducts pro = new WatchProducts(_user, ProductsDL.Inventory);
                Misc.Set_Form(pro, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("No Product Found");
            }
        }


        // Cart Button

        private void C_Cart_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            ShowMenu(C_Cart_Panel);
        }


        // Search Products
        private void C_SearchProduct_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            SearchData form = new SearchData(_user);
            Misc.Set_Form(form, menu_Display_Panel);
            form.ProductAddCart += AddCart_ProductAddCart;
        }
        private void AddCart_ProductAddCart(object sender, EventArgs e)
        {
            item = ProductsDL.ReturnProduct(((SearchData)sender).CartProduct.ToString());

            InputBox nform = new InputBox();
            nform.SetLabel("Enter the Quantity :");
            nform.SetButtonText("Add");
            nform.IsBtnClick += AddCart_IsBtnClick;            
            nform.ShowDialog();
        }
        private void AddCart_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                string name = item.GetProductName();
                int idx = ProductsDL.IsProductExists(name);
                if (idx != -1)
                {
                    float price = ProductsDL.ReturnProduct(name).GetProductPrice();
                    int quantity = int.Parse(((InputBox)sender).data);
                    int sale = ProductsDL.ReturnProduct(name).GetProductSale();

                    if (quantity < ProductsDL.ReturnProduct(name).GetProductQuantity())
                    {
                        _user.AddinCartList(new Products(name, price, quantity, sale));

                        MessageBox.Show("Item Added Successfully !!!");

                    }
                    else
                    {
                        MessageBox.Show("Enter valid number !");
                    }
                }
                else
                {
                    MessageBox.Show("Product doesn't Exists!!!");
                }
            }
        }


        // View Cart

        private void C_ViewCart_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            List<Products> list = _user.GetCartList();
            if (list?.Count > 0)
            {
                WatchProducts form = new WatchProducts(_user, list, 1);
                Misc.Set_Form(form, menu_Display_Panel);
                form.SetBillTable(Misc.BillCalculation(list).ToString());
            }
            else
            {
                MessageBox.Show("No Product added in Cart!!!");
            }
        }


        // Purchase Button

        private void C_Purchase_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            ShowMenu(C_Purchase_Panel);
        }

        // Watch Orders Given

        private void C_OrderGiven_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            List<Products> list = _user.GetOrdersList();
            if (list?.Count > 0)
            {
                WatchProducts form = new WatchProducts(_user, list, 2);
                form.SetBillTable(Misc.BillCalculation(list).ToString());
                Misc.Set_Form(form, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("No items Purchased!!!");
            }
        }


        // Items Received

        private void C_Received_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            List<Products> list = _user.GetReceivedList();
            if (list?.Count > 0)
            {
                WatchProducts form = new WatchProducts(_user, list, 2);
                Misc.Set_Form(form, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("No items Received!!!");
            }
        }


        // Watch Announcements

        private void C_Announcement_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();


        }


        // Change Password

        private void user_PasswordChange_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            Misc.ChangePassForm(menu_Display_Panel).IsBtnClick += Password_IsBtnClick;
        }
        private void Password_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                _user.ChangePass(((InputBox)sender).data);
                MessageBox.Show("Data Updated Successfully !");
            }
        }

        
    }
}
