using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePrinceArcher_Game.GUI_Forms
{
    public partial class MessageForm : Form
    {
        public event EventHandler IsContinueBtnClick;
        public event EventHandler IsReturnBtnClick;

        public MessageForm(Image img)
        {
            InitializeComponent();
            showImage_PB.Image = img;
        }
        
        private void continue_Btn_Click(object sender, EventArgs e)
        {
            IsContinueBtnClick?.Invoke(this, e);
            this.Close();
        }
        
        private void return_Btn_Click(object sender, EventArgs e)
        {
            IsReturnBtnClick?.Invoke(this, e);
            this.Close();
        }

        public void HideContinueBtn()
        {
            continue_Btn.Visible = false;
        }
    }
}
