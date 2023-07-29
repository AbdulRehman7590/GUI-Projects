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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RunForm();
        }

        private void RunForm()
        {
            MenuForm form = new MenuForm();
            form.StartBtnClick += MenuForm_StartBtnClick;
            form.InstructionsBtnClick += MenuForm_InstructionsBtnClick;
            form.ExitBtnClick += MenuForm_ExitBtnClick;
            Set_Form(form);
        }


        private void MenuForm_StartBtnClick(object sender, EventArgs e)
        {
            GameForm form = new GameForm();
            form.IsExitClick += GameForm_IsExitClick;
            Set_Form(form);
        }
        private void GameForm_IsExitClick(object sender, EventArgs e)
        {
            if (((GameForm)sender).isClick)
            {
                RunForm();
            }
        }

        private void MenuForm_InstructionsBtnClick(object sender, EventArgs e)
        {
            InstructionsForm form = new InstructionsForm();
            form.IsBackBtnClick += InstructionsForm_IsBackBtnClick;
            Set_Form(form);
        }
        private void InstructionsForm_IsBackBtnClick(object sender, EventArgs e)
        {
            RunForm();
        }



        private void MenuForm_ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Set_Form(Form name)
        {
            name.TopLevel = false;
            name.FormBorderStyle = FormBorderStyle.None;
            name.Dock = DockStyle.Fill;
            main_Panel.Controls.Add(name);
            main_Panel.Tag = name;
            name.BringToFront();
            name.Show();
        }

    }
}
