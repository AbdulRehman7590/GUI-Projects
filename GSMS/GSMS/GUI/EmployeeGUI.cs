using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMS.BL;
using GSMS.DL;

namespace GSMS.GUI
{
    public partial class EmployeeGUI : Form
    {
        private Employee _user;
        private int customerIndex = -1;
        private string receiver = null;

        public EmployeeGUI(Employee user)
        {
            this._user = user;
            this.InitializeComponent();
            this.HideAllMenus();
            Misc.ShowUserData(userName_lbl, userContact_lbl, _user);

        }

        private void HideAllMenus()
        {
            E_Products_Panel.Visible = false;
            E_Announcement_Panel.Visible = false;
            E_Messenger_Panel.Visible = false;
            menu_Display_Panel.Controls.Clear();
        }

        private void ShowMenu(Panel p)
        {
            p.Visible = true;
        }

        private void EmployeeGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }



        // Products Details

        private void E_ProductsDetails_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(E_Products_Panel);
        }

        // Watch Products

        private void E_ProductsWatch_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            if (!Misc.SeeProducts(_user, menu_Display_Panel))
            {
                MessageBox.Show("No Product Found");
            }
        }

        // Watch Low Quantity Products

        private void E_LowStockProduct_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            if (ProductsDL.Inventory.Count > 0)
            {
                Form emp = new WatchProducts(ProductsDL.Inventory);
                Misc.Set_Form(emp, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("No Product Found");
            }
        }


        // Orders Received Button

        private void E_OrdersReceive_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            if (EmployeeDL.Receipents1.Count > 0)
            {
                ViewUsers cust = new ViewUsers(EmployeeDL.Receipents1, _user);
                cust.CustomerSelected += Cust_CustomerSelected;
                Misc.Set_Form(cust, menu_Display_Panel);
            }
            else
            {
                MessageBox.Show("No Orders Received !!!");
            }
        }
        private void Cust_CustomerSelected(object sender, EventArgs e)
        {
            this.customerIndex = ((ViewUsers)sender).CustomerIndex;
            Orders_Received();
        }
        private void Orders_Received()
        {
            HideAllMenus();
            Form orders = new WatchProducts(_user, EmployeeDL.Orders(EmployeeDL.Return_Cust(customerIndex)));
            Misc.Set_Form(orders, menu_Display_Panel);
        }


        // Announcement Button 

        private void E_Announcement_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(E_Announcement_Panel);
        }

        // Make Announcement 

        private void E_make_announcement_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
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

        private void E_watch_Announcements_btn_Click(object sender, EventArgs e)
        {
            HideAllMenus();
            Misc.See_Announcements(menu_Display_Panel);
        }


        // Messenger Button

        private void E_Messenger_btn_Click(object sender, EventArgs e)
        {
            this.HideAllMenus();
            this.ShowMenu(E_Messenger_Panel);
        }

        // Send Message

        private void E_Sent_Message_btn_Click(object sender, EventArgs e)
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


        // Watch Message

        private void E_Read_Message_btn_Click(object sender, EventArgs e)
        {
            Misc.Read_Message(_user.GetName(), menu_Display_Panel);            
        }


        // Log Out

        private void E_LogOut_btn_Click(object sender, EventArgs e)
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
