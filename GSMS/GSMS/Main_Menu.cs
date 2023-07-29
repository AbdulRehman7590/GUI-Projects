using GSMS.DL;
using GSMS.Enums;
using GSMS.GUI;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS
{
    public partial class Main_Menu : Form
    {
        private int count = 0;

        public Main_Menu()
        {
            InitializeComponent();
            Load_Data();
            HideAllMenus();
        }

        private void HideAllMenus()
        {
            signUp_Role_Panel.Visible = false;
        }

        private void ShowMenu()
        {
            signUp_Role_Panel.Visible = true;
        }

        private void Load_Data()
        {
            if (UserDL.LoadPin() == false)
            {
                MessageBox.Show("Unable to load Pin data !!!");
            }
            if (UserDL.Load_Messages() == false)
            {
                MessageBox.Show("Unable to load Message data !!!");
            }
            if (UserDL.Loadlogindata() == false)
            {
                MessageBox.Show("Unable to load Users data !!!");
            }
            if (UserDL.Load_Announcements() == false)
            {
                MessageBox.Show("Unable to load Announcements data !!!");
            }
            if (ProductsDL.LoadProductsData() == false)
            {
                MessageBox.Show("Unable to load Products data !!!");
            }
            if (EmployeeDL.Load_Orders_Received_Data() == false)
            {
                MessageBox.Show("Unable to load Orders Received data !!!");
            }
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nform = new Log_In();
            nform.ShowDialog();
        }

        private void OpenSignUpForm(UserType user)
        {
            this.Hide();
            Form nform = new SignUp(user);
            nform.ShowDialog();
        }

        private void admin_SignUp_btn_Click(object sender, EventArgs e)
        {
            count = 1;

            if (UserDL.CheckAdmin())
            {
                HideAllMenus();
                EnterSignUpPin();
            }
            else
            {
                OpenSignUpForm(UserType.Admin);
            }
        }

        private void employee_SignUp_btn_Click(object sender, EventArgs e)
        {
            count = 2;
            HideAllMenus();
            EnterSignUpPin();
        }

        private void customer_SignUp_btn_Click(object sender, EventArgs e)
        {
            OpenSignUpForm(UserType.Customer);
        }

        private void EnterSignUpPin()
        {
            InputBox form = new InputBox();
            form.SetLabel("Enter Sign-Up Pin:");
            form.SetButtonText("Sign-Up");            
            form.IsBtnClick += Form_IsBtnClick;
            form.ShowDialog();
        }

        private void Form_IsBtnClick(object sender, EventArgs e)
        {
            if (((InputBox)sender).IsClick && ((InputBox)sender).data == UserDL.GetPin())
            {
                this.Hide();

                if (count == 1)
                {
                    OpenSignUpForm(UserType.Admin);
                }
                else if (count == 2)
                {
                    OpenSignUpForm(UserType.Employee);
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("You can't Sign Up without Pin!!!");
            }
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
