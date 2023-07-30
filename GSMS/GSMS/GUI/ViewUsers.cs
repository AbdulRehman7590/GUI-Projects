using System;
using GSMS.BL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Lifetime;
using GSMS.DL;

namespace GSMS.GUI
{
    public partial class ViewUsers : Form
    {
        public User user;
        
        
        public event EventHandler CustomerSelected;
        public int CustomerIndex { get => GV.SelectedCells[0].RowIndex; }


        public ViewUsers(List<Employee> list)
        {
            InitializeComponent();
            DataBind(list);
        }
        public ViewUsers(List<Customer> list, User user)
        {
            this.user = user;
            InitializeComponent();
            DataBind(list);
        }



        private void DataBind(List<Employee> list)
        {
            GV.DataSource = null;
            GV.DataSource = list.Select(c => new { c.Role, c.UserName, c.Contact }).ToList();
            GV.Refresh();
            AddDelButton();
        }


        private void DataBind(List<Customer> list)
        {
            GV.DataSource = null;
            GV.DataSource = list.Select(c => new { c.Role, c.UserName, c.Contact }).ToList();
            GV.Refresh();
            if (user is Admin)
            {
                AddDelButton();
            }
            else if (user is Employee)
            {
                AddShowButton();
                AddupdateButton();
            }
        }


        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddShowButton()
        {
            DataGridViewButtonColumn button = Misc.GV_AddButton("Orders", "Gv_Orders_Btn");
            GV.Columns.Add(button);
            GV.CellContentClick += Users_GV_Orders_CellContentClick;
        }
        private void Users_GV_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GV.SelectedCells[0].ColumnIndex == GV.Columns["Gv_Orders_Btn"].Index)
            {
                CustomerSelected?.Invoke(this, new EventArgs());
                this.Close();
            }
        }



        private void AddDelButton()
        {
            DataGridViewButtonColumn button = Misc.GV_AddButton("Delete", "Gv_Del_Btn");
            GV.Columns.Add(button);
            GV.CellContentClick += Users_GV_Del_CellContentClick;
        }
        private void Users_GV_Del_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.SelectedCells[0].ColumnIndex == GV.Columns["Gv_Del_Btn"].Index)
            {
                int idx = GV.SelectedCells[0].RowIndex;
                object cellValue = GV.Rows[idx].Cells["UserName"].Value;

                UserDL.RemoveFroUserList(UserDL.IsUserExists(cellValue.ToString()));
                UserDL.StoreUsersData();

                MessageBox.Show("User Deleted !!!");
                GV.Refresh();
            }
        }



        private void AddupdateButton()
        {
            DataGridViewButtonColumn button = Misc.GV_AddButton("Update", "Gv_Update_Btn");
            GV.Columns.Add(button);
            GV.CellContentDoubleClick += Users_GV_Update_CellContentDoubleClick; 
        }

        private void Users_GV_Update_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.SelectedCells[0].ColumnIndex == GV.Columns["Gv_Update_Btn"].Index)
            {
                EmployeeDL.UpdateTheListData(e.RowIndex);
                MessageBox.Show("Order is fulfilled !!!");
                GV.Refresh();
            }
        }

  
    }
}
