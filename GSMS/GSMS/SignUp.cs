using GSMS.BL;
using GSMS.DL;
using GSMS.Enums;
using GSMS.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GSMS
{
    public partial class SignUp : Form
    {
        private UserType _userType;

        public SignUp(UserType user)
        {
            InitializeComponent();
            _userType = user;
        }

        private void create_Account_btn_Click(object sender, EventArgs e)
        {
            if (signUp_userName_txt.Text != "" && signUp_Password_txt.Text != "" && signUp_Contact_txt.Text != "")
            {
                if (UserDL.CheckAdmin())
                {
                    if (Create_Account())
                    {
                        MessageBox.Show("Account Created Successfully !!!");
                    }
                    else
                    {
                        MessageBox.Show("User Already Exists");
                    }
                }
                else if (Create_Account())
                {
                    InputBox update = new InputBox();
                    update.SetLabel("Enter the Sign-Up Pin:");
                    update.ShowDialog();

                    if (((InputBox)sender).data != "")
                    {
                        update.IsBtnClick += Form_IsBtnClick;
                    }
                }
                else
                {
                    MessageBox.Show("User Already Exists");
                }
            }
        }

        private void Form_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick)
            {
                string pin = ((InputBox)sender).data;

                if (pin != null && pin.Length == 5)
                {
                    UserDL.SetPin(pin);

                    MessageBox.Show("Account Created Successfully !!!");
                    RefreshData();
                }
            }
        }

        private bool Create_Account()
        {
            bool result = false;
            string userName = signUp_userName_txt.Text;
            if (UserDL.IsUserExists(userName) != -1)
            {
                result = false;
            }
            else
            {
                string password = signUp_Password_txt.Text;
                string contact = signUp_Contact_txt.Text;

                if (_userType == UserType.Admin)
                {
                    Admin info = new Admin(UserType.Admin, userName, password, contact);
                    UserDL.AddinUserList(info);
                }
                else if (_userType == UserType.Employee)
                {
                    Employee info = new Employee(UserType.Employee, userName, password, contact);
                    UserDL.AddinUserList(info);
                }
                else if (_userType == UserType.Employee)
                {
                    Customer info = new Customer(UserType.Customer, userName, password, contact);
                    UserDL.AddinUserList(info);
                }
                result = true;
                UserDL.StoreUsersData();
            }
            return result;
        }

        private void RefreshData()
        {
            signUp_userName_txt.Text = null;
            signUp_Password_txt.Text = null;
            signUp_Contact_txt.Text = null;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu();
            form.Show();
            this.Close();
        }


        // Validating Functions
        
        // UserName
        private void signUp_userName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void signUp_userName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(signUp_userName_txt, string.Empty);
            if (!string.IsNullOrEmpty(signUp_userName_txt.Text.Trim()))
            {
                epSuccess.SetError(signUp_userName_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(signUp_userName_txt, string.Empty);
            }
        }

        private void signUp_userName_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(signUp_userName_txt.Text.Trim()))
            {
                epError.SetError(signUp_userName_txt, string.Empty);
            }
            else
            {
                epError.SetError(signUp_userName_txt, "Name is required.");
            }
        }


        // Password
        private void signUp_Password_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(signUp_Password_txt, string.Empty);
            if (!string.IsNullOrEmpty(signUp_Password_txt.Text.Trim()))
            {
                epSuccess.SetError(signUp_Password_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(signUp_Password_txt, string.Empty);
            }
        }

        private void signUp_Password_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(signUp_Password_txt.Text.Trim()))
            {
                epError.SetError(signUp_Password_txt, string.Empty);
            }
            else
            {
                epError.SetError(signUp_Password_txt, "Name is required.");
            }
        }


        // Contact
        private void signUp_Contact_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void signUp_Contact_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(signUp_Contact_txt, string.Empty);
            if (!string.IsNullOrEmpty(signUp_Contact_txt.Text.Trim()))
            {
                epSuccess.SetError(signUp_Contact_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(signUp_Contact_txt, string.Empty);
            }
        }

        private void signUp_Contact_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(signUp_Contact_txt.Text.Trim()))
            {
                epError.SetError(signUp_Contact_txt, string.Empty);
            }
            else
            {
                epError.SetError(signUp_Contact_txt, "Name is required.");
            }
        }
    }
}
