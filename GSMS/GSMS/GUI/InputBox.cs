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
            if (update_Data_Txt.Text != "")
            {
                Is_Click = true;
                IsBtnClick?.Invoke(this, e);
                this.Close();
                this.Hide();
            }
        }

        public void SetLabel(string line)
        {
            updated_lbl.Text = line;
        }

        public void SetButtonText(string line)
        {
            update_btn.Text = line;
        }



        // Validation Functions
        
        private void update_Data_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void update_Data_Txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(update_Data_Txt, string.Empty);
            if (!string.IsNullOrEmpty(update_Data_Txt.Text.Trim()))
            {
                epSuccess.SetError(update_Data_Txt, "Valid");
            }
            else
            {
                epSuccess.SetError(update_Data_Txt, string.Empty);
            }
        }

        private void update_Data_Txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(update_Data_Txt.Text.Trim()))
            {
                epError.SetError(update_Data_Txt, string.Empty);
            }
            else
            {
                epError.SetError(update_Data_Txt, "Name is required.");
            }
        }
    }
}
