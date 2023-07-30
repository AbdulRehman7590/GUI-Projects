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
    public partial class MenuForm : Form
    {
        public event EventHandler StartBtnClick;
        public event EventHandler InstructionsBtnClick;
        public event EventHandler StoryBtnClick;
        public event EventHandler ExitBtnClick;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void start_Btn_Click(object sender, EventArgs e)
        {
            StartBtnClick?.Invoke(this, e);
            this.Close();
        }

        private void instruction_Btn_Click(object sender, EventArgs e)
        {
            InstructionsBtnClick?.Invoke(this, e);
            this.Close();
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            ExitBtnClick?.Invoke(this, e);
            this.Close();
        }

        private void story_Btn_Click(object sender, EventArgs e)
        {
            StoryBtnClick?.Invoke(this, e);
            this.Close();
        }
    }
}
