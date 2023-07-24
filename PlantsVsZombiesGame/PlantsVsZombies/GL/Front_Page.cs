using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombies.GL
{
    public partial class Front_Page : Form
    {
        public event EventHandler StartBtnClick;

        private bool isClick;

        public bool Is_Click { get => isClick; }

        
        public Front_Page()
        {
            InitializeComponent();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            isClick = true;
            StartBtnClick?.Invoke(this, e);
            this.Close();
        }

        private void Eit_Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
