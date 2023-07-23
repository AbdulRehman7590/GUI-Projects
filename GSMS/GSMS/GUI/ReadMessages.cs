using GSMS.DL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

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

        /* private void DataBind(List<string> list) 
         {
             msg_Display_GV.DataSource = null;
             var result = list.Select(x => new { value = x }).ToList();
             msg_Display_GV.DataSource = result;
             msg_Display_GV.Refresh();
         }*/

        private void DataBind(List<string> list)
        {
            DataContainer dataContainer = new DataContainer
            {
                Items = list
            };

            // Serialize the DataContainer object to a JSON string
            var jsonString = JsonConvert.SerializeObject(dataContainer);

            // Display the JSON object in the DataGridView
            msg_Display_GV.DataSource = jsonString;
        }
    }
}
