using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMS.BL;

namespace GSMS.DL
{
    class EmployeeDL
    {
        private static List<List<Products>> Orders_Received = new List<List<Products>>();
        private static List<Customer> Receipents = new List<Customer>();


        internal static List<List<Products>> Orders_Received1 { get => Orders_Received; set => Orders_Received = value; }
        internal static List<Customer> Receipents1 { get => Receipents; set => Receipents = value; }


        public static void AddInOrderList(List<Products> list)
        {
            Orders_Received.Add(list);
        }

        private static void RemoveFromOrderList(int idx)
        {
            Receipents[idx].Addin_Received_List(Orders_Received[idx]);
            Receipents[idx].RemoveFrom_Orders_Placed_List();
            Orders_Received.RemoveAt(idx);
        }

        public static void AddInCustomerList(Customer c)
        {
            Receipents.Add(c);
            Store_Orders_Received_Data();
        }

        private static void RemoveFromCustomerList(int idx)
        {
            Receipents.RemoveAt(idx);
            Store_Orders_Received_Data();
        }

        public static Customer Return_Cust(int idx)
        {
            return Receipents[idx];
        }


        public static List<Products> Orders(Customer c)
        {
            List<Products> list = null;

            for (int x = 0; x < Receipents1.Count; x++)
            {
                if (c == Receipents[x])
                {
                    list = Orders_Received1[x];
                    break;
                }
            }
            return list;
        }

        public static void UpdateTheListData(int idx)
        {
            RemoveFromOrderList(idx);
            RemoveFromCustomerList(idx);
        }


        public static void Store_Orders_Received_Data()
        {
            StreamWriter myFile = new StreamWriter("Orders_Received_Data.txt");
            for (int x = 0; x < Receipents1.Count; x++)
            {
                myFile.Write(Receipents1[x].GetName() + ",");

                foreach (var item in Orders_Received1[x])
                {
                    myFile.Write(item.GetProductName() + ";" + item.GetProductPrice() + ";" + item.GetProductQuantity() + ";" + item.GetProductSale() + "|");
                }

                myFile.WriteLine();
            }
            myFile.Flush();
            myFile.Close();
        }

        public static bool Load_Orders_Received_Data()
        {
            bool result = false;
            string line;
            if (File.Exists("Orders_Received_Data.txt"))
            {
                Receipents.Clear();
                Orders_Received.Clear();
                StreamReader myFile = new StreamReader("Orders_Received_Data.txt");

                while (!(myFile.EndOfStream))
                {
                    line = myFile.ReadLine();

                    if (line != "")
                    {
                        string[] splitarray = line.Split(',');

                        string custName = splitarray[0];
                        Customer cust = UserDL.Return_Customer(UserDL.IsUserExists(custName));
                        Receipents1.Add(cust);

                        string[] pro = splitarray[1].Split('|');
                        List<Products> list = new List<Products>();

                        for (int i = 0; i < pro.Length; i++)
                        {
                            if (pro[i] != "")
                            {
                                string[] data = pro[i].Split(';');
                                list.Add(new Products(data[0], float.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3])));
                            }
                        }

                        cust.Addin_Orders_placed_List(list);
                        AddInOrderList(list);
                    }
                }
                result = true;
                myFile.Close();
            }
            return result;
        }


    }
}
