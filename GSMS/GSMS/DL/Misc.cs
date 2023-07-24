using GSMS.BL;
using GSMS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GSMS.DL
{ 
    internal class Misc
    {
        public static void ShowUserData(Label pname1, Label pname2, User user)
        {
            pname1.Text = user.GetName();
            pname2.Text = user.GetContact();
        }

        public static void Logout(Form form)
        {
            form.Close();
            form.Hide();
            Form nform = new Main_Menu();
            nform.ShowDialog();
        }

        public static void Set_Form(Form name, Panel p_name)
        {
            name.TopLevel = false;
            name.FormBorderStyle = FormBorderStyle.None;
            name.Dock = DockStyle.Fill;
            p_name.Controls.Add(name);
            p_name.Tag = name;
            name.BringToFront();
            name.Show();
        }

        public static InputBox Asking_UserName(Panel pname)
        {
            InputBox form = new InputBox();
            form.SetLabel("Enter the receiver name :");
            form.SetButtonText("Select");
            Set_Form(form, pname);
            return form;
        }

        public static InputBox Write_Message(Panel pname)
        {
            InputBox form = new InputBox();
            form.SetLabel("Enter your message :");
            form.SetButtonText("Send");
            Set_Form(form, pname);
            return form;
        }


        public static InputBox ChangePassForm(Panel pname)
        {
            InputBox nform = new InputBox();
            nform.SetLabel("Enter the new password :");
            Set_Form(nform, pname);
            return nform;
        }

        public static bool SeeProducts(User user, Panel pname)
        {
            bool result = false;
            if (ProductsDL.Inventory?.Count > 0)
            {
                WatchProducts emp = new WatchProducts(user, ProductsDL.Inventory);
                Set_Form(emp, pname);
                result = true;
            }
            return result;
        }

        public static float BillCalculation(List<Products> list)
        {
            float money, discount, amount = 0;

            foreach (var item in list)
            {
                money = item.GetProductPrice() * item.GetProductQuantity();

                if (item.GetProductSale() > 0)
                {
                    discount = (item.GetProductPrice() * item.GetProductSale()) / 100;
                    money = money - (discount * item.GetProductQuantity());
                }
                amount += money;
            }

            return amount;
        }


        public static DataGridViewButtonColumn GV_AddButton(string headingname, string name)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            
            buttonColumn.HeaderText = headingname;
            buttonColumn.Text = headingname;
            buttonColumn.UseColumnTextForButtonValue = true;

            buttonColumn.Name = name;


            return buttonColumn;
        }


        public static void Read_Message(string name, Panel pname)
        {
            List<string> list = UserDL.ReceivedMessage(name);
            if (list?.Count > 0)
            {
                ReadMessages form = new ReadMessages(list);
                Set_Form(form, pname);
            }
            else
            {
                MessageBox.Show("No message Revceived");
            }
        }
        

    }
}
