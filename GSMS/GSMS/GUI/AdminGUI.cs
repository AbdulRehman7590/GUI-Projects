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
    public partial class AdminGUI : Form
    {
        private Admin _user;
        private object idx = null;
        private string receiver = null;

        public AdminGUI(Admin user)
        {
            this._user = user;
            this.InitializeComponent();
            Main_image.BackColor = Color.Transparent;
            this.HideAllMenus();
            Misc.ShowUserData(userName_lbl, userContact_lbl, _user);
        }


        private void HideAllMenus()
        {
            admin_Products_Options_Panel.Visible = false;
            manage_Employee_Options_Panel.Visible = false;
            messenger_Options_Panel.Visible = false;
            announcement_Options_Panel.Visible = false;

            menu_Display_Panel.Controls.Clear();
        }

        private void ShowMenu(Panel p)
        {
            p.Visible = true;
        }

        private void AdminGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }




        // Products Details

        private void products_Details_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(admin_Products_Options_Panel);
        }


        // Watch Products

        private void watch_Products_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (!Misc.SeeProducts(_user, menu_Display_Panel))
            {
                MessageBox.Show("No Product Found");
            }
        }


        // Add Products

        private void add_Products_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            AddProduct form = new AddProduct(_user);
            Misc.Set_Form(form, menu_Display_Panel);
        }


        // Product Selected Event Form

        private void Form_ProductSelected(object sender, EventArgs e)
        {
            SearchData searchData = ((SearchData)sender);
            idx = searchData.SelectedProduct;
            InputBox nform = searchData.Tag as InputBox;
            Misc.Set_Form(nform, menu_Display_Panel);
        }


        // Update Price

        private void update_Price_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            SearchData form = new SearchData(_user);
            InputBox nform = new InputBox();
            nform.IsBtnClick += Price_IsBtnClick;
            form.Tag = nform;
            Misc.Set_Form(form, menu_Display_Panel);
            form.ProductSelected += Form_ProductSelected;

        }
        private void Price_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                ProductsDL.ReturnProduct(idx.ToString()) . SetProductPrice(float.Parse(((InputBox)sender).data));
                MessageBox.Show("Data Updated Successfully !");
            }
        }


        // Update Quantity

        private void update_Stock_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            SearchData form = new SearchData(_user);
            InputBox nform = new InputBox();
            nform.IsBtnClick += Quantity_IsBtnClick;
            form.Tag = nform;
            Misc.Set_Form(form, menu_Display_Panel);
            form.ProductSelected += Form_ProductSelected;
        }
        private void Quantity_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                ProductsDL.ReturnProduct(idx.ToString()) . SetProductQuantity(int.Parse(((InputBox)sender).data));
                MessageBox.Show("Data Updated Successfully !");
            }
        }


        // Add / Remove Sale

        private void add_Sale_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            SearchData form = new SearchData(_user);
            InputBox nform = new InputBox();
            nform.IsBtnClick += Sale_IsBtnClick;
            form.Tag = nform;
            Misc.Set_Form(form, menu_Display_Panel);
            form.ProductSelected += Form_ProductSelected;
        }
        private void Sale_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                ProductsDL.ReturnProduct(idx.ToString()) . SetProductSale(int.Parse(((InputBox)sender).data));
                MessageBox.Show("Data Updated Successfully !");
            }
        }



        // Watch Employee Button

        private void employee_Manage_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(manage_Employee_Options_Panel);
        }

        // Watch Employee

        private void watch_Employee_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            List<Employee> list = UserDL.GetAllEmployees();
            if (list?.Count > 0)
            {
                Form cust = new ViewUsers(list);
                Misc.Set_Form(cust, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("Not Found !!! ");
            }
        }



        // Customer Traffic

        private void customer_Traffic_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            List<Customer> list = UserDL.GetAllCustomers();
            if (list?.Count > 0)
            {
                Form cust = new ViewUsers(list, _user);
                Misc.Set_Form(cust, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("Not Found !!! ");
            }
        }



        // Messenger Button

        private void admin_Messenger_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(messenger_Options_Panel);
        }


        // Send Message

        private void sent_Message_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            Misc.Asking_UserName(menu_Display_Panel).IsBtnClick += Form_IsBtnClick;
        }
        private void Form_IsBtnClick(object sender, EventArgs e)
        {
            receiver = ((InputBox)sender).data;
            if (UserDL.IsUserExists(receiver) != -1)
            {
                Misc.Write_Message(menu_Display_Panel).IsBtnClick += Msg_IsBtnClick;
            }
            else
            {
                MessageBox.Show("No User Exists !!");
            }

        }
        private void Msg_IsBtnClick(object sender, EventArgs e)
        {
            string message = ((InputBox)sender).data.ToString();
            if (((InputBox)sender).IsClick && message != null)
            {
                if (UserDL.SentMessage(_user.GetName(), receiver, message))
                {
                    MessageBox.Show("Message has been sent ");
                }
            }
        }


        // Read Messages

        private void read_Message_btn_Click(object sender, EventArgs e)
        {
            Misc.Read_Message(_user.GetName(), menu_Display_Panel);
        }




        // Announcement Button

        private void announcement_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(announcement_Options_Panel);
        }

        // Make Announcement

        private void make_announcement_btn_Click(object sender, EventArgs e)
        {
            Misc.Write_Message(menu_Display_Panel).IsBtnClick += Announcement_IsBtnClick;
        }
        private void Announcement_IsBtnClick(object sender, EventArgs e)
        {
            string message = ((InputBox)sender).data.ToString();
            if (((InputBox)sender).IsClick && message != null)
            {
                UserDL.SentAnnouncement(_user.GetName(), message);
                MessageBox.Show("Announcement is Posted !!! ");
            }
        }

        // Watch Announcement

        private void watch_Announcements_btn_Click(object sender, EventArgs e)
        {

        }



        // Log Out 

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            Misc.Logout(this);
        }


        // Password Change

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
