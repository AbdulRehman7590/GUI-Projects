using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMS.DL;

namespace GSMS.BL
{
    public class Products
    {
        private string ProductName1;
        private float Price1;
        private int Quantity1;
        private int ThresholdQuantity1;
        private int Sale1;


        public string ProductName { get => ProductName1; set => ProductName1 = value; }
        public float Price { get => Price1; set => Price1 = value; }
        public int Quantity { get => Quantity1; set => Quantity1 = value; }        
        public int ThresholdQuantity { get => ThresholdQuantity1; set => ThresholdQuantity1 = value; }
        public int Sale { get => Sale1; set => Sale1 = value; }

        public Products(string ProductName, float Price, int Quantity, int Sale)
        {
            this.ProductName1 = ProductName;
            this.Price1 = Price;
            this.Quantity1 = Quantity;
            this.Sale1 = Sale;
        }

        public Products(string ProductName, float Price, int Quantity, int ThresholdQuantity, int Sale)
        {
            this.ProductName1 = ProductName;
            this.Price1 = Price;
            this.Quantity1 = Quantity;
            this.ThresholdQuantity1 = ThresholdQuantity;
            this.Sale1 = Sale;
        }

        public string GetProductName()
        {
            return this.ProductName1;
        }

        public float GetProductPrice()
        {
            return this.Price1;
        }

        public void SetProductPrice(float Price)
        {
            this.Price1 = Price;
            ProductsDL.StoreProductsData();
        }

        public int GetProductQuantity()
        {
            return this.Quantity1;
        }

        public void SetProductQuantity(int Quantity)
        {
            this.Quantity1 = Quantity;
            ProductsDL.StoreProductsData();
        }

        public int GetProductThreshold()
        {
            return this.ThresholdQuantity1;
        }


        public int GetProductSale()
        {
            return this.Sale1;
        }

        public void SetProductSale(int Sale)
        {
            this.Sale1 = Sale;
            ProductsDL.StoreProductsData();
        }





    }
}
