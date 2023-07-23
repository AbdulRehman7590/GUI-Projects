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
    public partial class InputBox : Form
    {
        public event EventHandler IsBtnClick;

        public bool IsClick
        {
            get => Is_Click;
        }

        public string data
        {
            get => update_Data_Txt.Text;
        }

        private bool Is_Click;
        public InputBox()
        {
            Is_Click = false;
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Is_Click = true;
            IsBtnClick?.Invoke(this, e);
            this.Close();
        }

        public void SetLabel(string line)
        {
            updated_lbl.Text = line;
        }

        public void SetButtonText(string line)
        {
            update_btn.Text = line;
        }
    }
}
