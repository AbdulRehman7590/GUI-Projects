using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GSMS.GUI
{
    public partial class ReadMessages : Form
    {
        public ReadMessages(List<string> list)
        {
            InitializeComponent();
            DataBind(list);
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataBind(List<string> list)
        {
            msg_Display_GV.DataSource = null;
            msg_Display_GV.DataSource = list.Select(s => new { value = s }).ToList();
            msg_Display_GV.Refresh();
        }
    }
}
