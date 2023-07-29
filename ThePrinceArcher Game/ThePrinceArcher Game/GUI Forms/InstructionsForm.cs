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
    public partial class InstructionsForm : Form
    {
        public event EventHandler IsBackBtnClick;
        
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            IsBackBtnClick?.Invoke(this, e);
            this.Close();
        }
    }
}
