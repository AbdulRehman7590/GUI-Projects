using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMS.BL;
using System.IO;
using System.Runtime.CompilerServices;

namespace GSMS.DL
{
    class ProductsDL
    {
        private static List<Products> inventory = new List<Products>();


        internal static List<Products> Inventory { get => inventory; set => inventory = value; }


        public static void AddinProductsList(Products P)
        {
            inventory.Add(P);
        }

        public static void RemoveinProductsList(int idx)
        {
            inventory.RemoveAt(idx);
        }


        public static int IsProductExists(string pname)
        {
            int num = -1;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].GetProductName() == pname)
                {
                    num = i;
                    break;
                }
            }
            return num;
        }

        public static Products ReturnProduct(string name)
        {
            Products item = null;
            foreach (var x in inventory)
            {
                if(x.GetProductName() == name)
                {
                    item = x; break;
                }
            }
            return item;
        }



        public static void Minus_Quantity(Products p)
        {
            Products a = ReturnProduct(p.ProductName);
            
            if ((a.Quantity - p.Quantity) < 0)
            {
                p.SetProductQuantity(a.Quantity);
            }
            
            a.SetProductQuantity( a.Quantity - p.Quantity );
        }


        public static List<Products> Search_Product(string s)
        {
            List<Products> product = inventory.FindAll(item => item.GetProductName().StartsWith(s));            
            return product;
        }



        public static void StoreProductsData()
        {
            StreamWriter myFile = new StreamWriter("ProductsData.txt");
            foreach (var x in inventory)
            {
                myFile.WriteLine(x.GetProductName() + "," + x.GetProductPrice() + "," + x.GetProductQuantity() + "," + x.GetProductThreshold() + "," + x.GetProductSale());
            }
            myFile.Flush();
            myFile.Close();
        }

        public static bool LoadProductsData()
        {
            bool result = false;
            string line;
            if (File.Exists("ProductsData.txt"))
            {
                inventory.Clear();
                StreamReader myFile = new StreamReader("ProductsData.txt");
                while (!(myFile.EndOfStream))
                {
                    line = myFile.ReadLine();
                    if (line != "")
                    {
                        string[] splittedarray = line.Split(',');

                        string productName = splittedarray[0];
                        float price = float.Parse(splittedarray[1]);
                        int quantity = int.Parse(splittedarray[2]);
                        int sale = int.Parse(splittedarray[4]);

                        if (productName != null && IsNum(price.ToString()) && IsNum(quantity.ToString()) && IsNum(sale.ToString()))
                        {
                            int threshold = (40 * quantity) / 100;
                            AddinProductsList(new Products(productName, price, quantity, threshold, sale));
                        }
                    }
                }
                result = true;
                myFile.Close();
            }
            return result;
        }

        private static bool IsNum(string str) 
        {
            bool result = false;
            if (str != null)
            {
                foreach (var i in  str)
                {
                    if((int)i >= 48 && (int)i <= 58)
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }

    }
}
