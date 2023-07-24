using PlantsVsZombies.GL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombies
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DisplayForm();
        }
        
        private void SetForm(Form name)
        {
            name.TopLevel = false;
            name.FormBorderStyle = FormBorderStyle.None;
            name.Dock = DockStyle.Fill;
            main_Panel.Controls.Add(name);
            main_Panel.Tag = name;
            name.BringToFront();
            name.Show();
        }

        
        private void DisplayForm()
        {
            Front_Page form = new Front_Page();
            form.StartBtnClick += Form_StartBtnClick;
            SetForm(form);
        }

        
        private void Form_StartBtnClick(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            SetForm(game);
        }

    }
}
