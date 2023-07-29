using GSMS.BL;
using GSMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GSMS.GUI
{
    public partial class AddProduct : Form
    {
        private User user = null;
        public AddProduct(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (product_Name_txt.Text != "" && product_Price_txt.Text != "" && product_Quantity_txt.Text != "" && product_Sale_txt.Text != "")
            {
                AdProduct();
            }
        }

        private void AdProduct()
        {
            string name = product_Name_txt.Text;
            if (ProductsDL.IsProductExists(name) == -1 && name != "")
            {
                float price = float.Parse(product_Price_txt.Text);
                int quantity = int.Parse(product_Quantity_txt.Text);
                int threshold = (40 * quantity) / 100;
                int sale = int.Parse(product_Sale_txt.Text);
                Products items = new Products(name, price, quantity, threshold, sale);

                ProductsDL.AddinProductsList(items);
                ProductsDL.StoreProductsData();
                MessageBox.Show("Product Added!!!");
                RefreshingData();
            }
            else
            {
                MessageBox.Show("Product Exists!!!");
                RefreshingData();
            }
        }


        private void RefreshingData()
        {
            product_Name_txt.Text = null;
            product_Price_txt.Text = null;
            product_Quantity_txt.Text = null;
            product_Sale_txt.Text = null;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Validation Functions

        // Name Validation
        private void product_Name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }


        private void product_Name_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(product_Name_txt, string.Empty);
            if (!string.IsNullOrEmpty(product_Name_txt.Text.Trim()))
            {
                epSuccess.SetError(product_Name_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(product_Name_txt, string.Empty);
            }
        }

        private void product_Name_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(product_Name_txt.Text.Trim()))
            {
                epError.SetError(product_Name_txt, string.Empty);
            }
            else
            {
                epError.SetError(product_Name_txt, "Name is required.");
            }
        }


        // Price Validation
        private void product_Price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void product_Price_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(product_Price_txt, string.Empty);
            if (!string.IsNullOrEmpty(product_Price_txt.Text.Trim()))
            {
                epSuccess.SetError(product_Price_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(product_Price_txt, string.Empty);
            }
        }

        private void product_Price_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(product_Price_txt.Text.Trim()))
            {
                epError.SetError(product_Price_txt, string.Empty);
            }
            else
            {
                epError.SetError(product_Price_txt, "Name is required.");
            }
        }
        

        // Quantity Validation
        private void product_Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void product_Quantity_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(product_Quantity_txt, string.Empty);
            if (!string.IsNullOrEmpty(product_Quantity_txt.Text.Trim()))
            {
                epSuccess.SetError(product_Quantity_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(product_Quantity_txt, string.Empty);
            }
        }

        private void product_Quantity_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(product_Quantity_txt.Text.Trim()))
            {
                epError.SetError(product_Quantity_txt, string.Empty);
            }
            else
            {
                epError.SetError(product_Quantity_txt, "Name is required.");
            }
        }
        

        // Sale Validation
        private void product_Sale_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void product_Sale_txt_KeyUp(object sender, KeyEventArgs e)
        {
            epError.SetError(product_Sale_txt, string.Empty);
            if (!string.IsNullOrEmpty(product_Sale_txt.Text.Trim()))
            {
                epSuccess.SetError(product_Sale_txt, "Valid");
            }
            else
            {
                epSuccess.SetError(product_Sale_txt, string.Empty);
            }
        }

        private void product_Sale_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(product_Sale_txt.Text.Trim()))
            {
                epError.SetError(product_Sale_txt, string.Empty);
            }
            else
            {
                epError.SetError(product_Sale_txt, "Name is required.");
            }
        }
    }
}
