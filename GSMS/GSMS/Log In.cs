using GSMS.BL;
using GSMS.DL;
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
using System.Xml.Linq;

namespace GSMS
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void Log_In_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form nform = new Main_Menu();
            nform.ShowDialog();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            User loginUser = UserDL.SignIN(SignIn_User());

            if (loginUser != null)
            {
                this.Close();
                this.Hide();

                if (loginUser is Admin)
                {
                    Admin person = (Admin)loginUser;
                    Form nform = new AdminGUI(person);
                    nform.ShowDialog();
                }
                else if (loginUser is Employee)
                {
                    Employee person = (Employee)loginUser;
                    Form nform = new EmployeeGUI(person);
                    nform.ShowDialog();
                }
                else if (loginUser is Customer)
                {
                    Customer person = (Customer)loginUser;
                    Form nform = new CustomerGUI(person);
                    nform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No User Found");
            }
        }

        private User SignIn_User()
        {
            User user;
            string name, pass;
            do
            {
                name = logIn_UserName_txt.Text;
                pass = logIn_Password_txt.Text;
            }
            while (name == null && pass == null);

            return user = new User(name, pass);
        }

        private void logIn_UserName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void logIn_UserName_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(logIn_UserName_txt, string.Empty);
            if (!string.IsNullOrEmpty(logIn_UserName_txt.Text.Trim()))
            {
                epSuccess.SetError(logIn_UserName_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(logIn_UserName_txt, string.Empty);
            }
        }

    }
}
