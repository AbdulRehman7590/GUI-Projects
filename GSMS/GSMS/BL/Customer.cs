using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMS.DL;
using GSMS.Enums;

namespace GSMS.BL
{
    public class Customer : User
    {
        private List<Products> cart = new List<Products>();
        private List<Products> orders_Placed = new List<Products>();
        private List<Products> received_Items = new List<Products>();

        public List<Products> Cart { get => cart; set => cart = value; }
        public List<Products> Orders_Placed { get => orders_Placed; set => orders_Placed = value; }
        public List<Products> Received_Items { get => received_Items; set => received_Items = value; }

        public Customer(UserType role, string userName, string password, string contact) : base(role, userName, password, contact)
        {
        }


        public void AddinCartList(Products p)
        {
            cart.Add(p);
        }

        public void ClearCartList()
        {
            cart.Clear();
        }

        public void RemovefromCartList(Products p)
        {
            cart.Remove(p);
        }

        public void RemoveFrom_Orders_Placed_List()
        {
            orders_Placed.Clear();
        }

        public void Addin_Orders_placed_List(List<Products> list)
        {
            orders_Placed = list;
        }

        public void Addin_Received_List(List<Products> list)
        {
            foreach (var item in list)
            {
                received_Items.Add(item);
            }
        }

        public List<Products> GetCartList()
        {
            return cart;
        }

        public List<Products> GetOrdersList()
        {
            return orders_Placed;
        }

        public List<Products> GetReceivedList()
        {
            return received_Items;
        }


    }
}
