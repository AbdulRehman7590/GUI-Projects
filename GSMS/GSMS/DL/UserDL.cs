using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using GSMS.BL;
using GSMS.Enums;
using System.Web.UI.WebControls;

namespace GSMS.DL
{
    class UserDL
    {
        private static string pin = "";
        private static List<User> LoginInfo = new List<User>();
        private static List<List<string>> Announcement = new List<List<string>>();
        private static List<List<string>> Message = new List<List<string>>();


        public static string Pin { get => pin; set => pin = value; }
        internal static List<User> LoginInfo1 { get => LoginInfo; set => LoginInfo = value; }
        public static List<List<string>> Announcement1 { get => Announcement; set => Announcement = value; }
        public static List<List<string>> Message1 { get => Message; set => Message = value; }


        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (var x in LoginInfo)
            {
                if (x is Employee person)
                {
                    employees.Add(person);
                }
            }
            return employees;
        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            foreach (var x in LoginInfo)
            {
                if (x is Customer person)
                {
                    customers.Add(person);
                }
            }
            return customers;
        }




        public static void AddinUserList(User a)
        {
            LoginInfo.Add(a);
        }

        public static void RemoveFroUserList(int idx)
        {
            LoginInfo.RemoveAt(idx);
        }


        public static string GetPin()
        {
            return Pin;
        }

        public static void SetPin(string p)
        {
            Pin = p;
            UpdatePin();
        }


        public static bool CheckAdmin()
        {
            bool flag = false;
            foreach (var x in LoginInfo)
            {
                if (x is Admin)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }


        public static int IsUserExists(string cname)
        {
            int num = -1;
            for (int x = 0; x < LoginInfo.Count; x++)
            {
                if (LoginInfo1[x].GetName() == cname)
                {
                    num = x;
                    break;
                }
            }
            return num;
        }


        public static Customer Return_Customer(int idx)
        {
            return (Customer)LoginInfo[idx];
        }


        public static User SignIN(User user)
        {
            User person = null;

            foreach (var x in LoginInfo1)
            {
                if (x.GetName() == user.GetName() && x.GetPass() == user.GetPass())
                {
                    person = x;
                    break;
                }
            }

            return person;
        }



        public static void SentAnnouncement(string loginName, string message)
        {
            List<string> list = null;
            int idx = 0;
            foreach (var x in Announcement1)
            {
                if (x[0] == loginName)
                {
                    list = x;
                    break;
                }
                idx++;
            }
            if (idx >= Announcement1.Count)
            {
                list = new List<string>();
                list.Add(loginName);
            }

            list.Add(message);

            if (idx >= Announcement1.Count)
            {
                Announcement1.Add(list);
            }
            Store_Announcement();
        }

        public static List<string> WatchAnnouncement(int count)
        {
            List<string> list = null;
            for (int i = 0; i < Announcement?.Count; i++)
            {
                if (i == count)
                {
                    list = Announcement[count];
                }
            }
            return list;
        }

        public static bool SentMessage(string loginName, string receiver, string msg)
        {
            int idx;
            bool result = false;

            idx = IsUserExists(receiver);
            if (idx != -1)
            {
                List<string> list = null;
                bool count = false;
                foreach (var x in Message)
                {
                    if (x[0] == receiver && x[1] == loginName)
                    {
                        list = x;
                        count = true;
                        break;
                    }
                }

                if (!count)
                {
                    list = new List<string>();
                    list.Add(receiver);
                    list.Add(loginName);
                }
                
                string msg1 = "==>>" + msg;
                list.Add(msg1);

                if (!count)
                {
                    Message.Add(list);
                }

                result = true;
                Store_Message();
            }
            return result;
        }


        public static List<string> ReceivedMessage(string loginName, int count)
        {
            int idx = 0;
            List<string> list = null;
            foreach (var innerlist in Message1)
            {
                if (innerlist[0] == loginName && count == idx)
                {
                    list = innerlist;
                }
                idx++;
            }
            return list;
        }


        /* UserS Data */

        public static void StoreUsersData()
        {
            StreamWriter myFile = new StreamWriter("UserData.txt");
            foreach (var x in LoginInfo)
            {
                myFile.WriteLine(x.GetRole() + "," + x.GetName() + "," + x.GetPass() + "," + x.GetContact());
            }
            myFile.Flush();
            myFile.Close();
        }

        public static bool Loadlogindata()
        {
            bool result = false;
            string line;
            if (File.Exists("UserData.txt"))
            {
                LoginInfo.Clear();
                StreamReader myFile = new StreamReader("UserData.txt");
                while (!(myFile.EndOfStream))
                {
                    line = myFile.ReadLine();
                    if (line != "")
                    {
                        string[] splitarray = line.Split(',');

                        string role = splitarray[0];
                        string name = splitarray[1];
                        string password = splitarray[2];
                        string contact = splitarray[3];

                        if (name != null && password != null && contact != null)
                        {
                            if (role == (UserType.Admin).ToString())
                            {
                                AddinUserList(new Admin(UserType.Admin, name, password, contact));
                            }
                            else if (role == (UserType.Employee).ToString())
                            {
                                AddinUserList(new Employee(UserType.Employee, name, password, contact));
                            }
                            else if (role == (UserType.Customer).ToString())
                            {
                                AddinUserList(new Customer(UserType.Customer, name, password, contact));
                            }
                        }
                    }
                }
                result = true;
                myFile.Close();
            }
            return result;
        }


        /* Admin Pin */
        public static bool LoadPin()
        {
            bool result = false;
            if (File.Exists("AdminPin.txt"))
            {
                pin = null;
                StreamReader File = new StreamReader("AdminPin.txt");
                Pin = File.ReadLine();
                File.Close();
                result = true;
            }
            return result;
        }

        public static void UpdatePin()
        {
            StreamWriter File = new StreamWriter("AdminPin.txt");
            File.WriteLine(Pin);
            File.Flush();
            File.Close();
        }


        /* Announcements */

        public static void Store_Announcement()
        {
            StreamWriter File = new StreamWriter("Announcements.txt");
            foreach (var innerList in Announcement1)
            {
                foreach (var x in innerList)
                {
                    File.Write(x + ",");
                }
                File.WriteLine();
            }
            File.Close();
        }

        public static bool Load_Announcements()
        {
            bool result = false;
            string line;
            if (File.Exists("Announcements.txt"))
            {
                Announcement.Clear();
                StreamReader File = new StreamReader("Announcements.txt");

                while (!(File.EndOfStream))
                {
                    line = File.ReadLine();

                    if (line != "")
                    {
                        string[] array = line.Split(',');

                        List<string> list = new List<string>();
                        list.Add(array[0]);

                        for (int i = 1; i < array.Length - 1; i++)
                        {
                            if (array[i] != "")
                            {
                                list.Add(array[i]);
                            }
                        }

                        Announcement1.Add(list);
                    }
                }
                result = true;
                File.Close();
            }
            return result;
        }



        /* Messenger */

        public static void Store_Message()
        {
            StreamWriter File = new StreamWriter("Messenger.txt");
            foreach (var innerList in Message1)
            {
                foreach (var x in innerList)
                {
                    File.Write(x + ",");
                }
                File.WriteLine();
            }
            File.Close();
        }

        public static bool Load_Messages()
        {
            bool result = false;
            string line;
            if (File.Exists("Messenger.txt"))
            {
                Message.Clear();
                StreamReader File = new StreamReader("Messenger.txt");

                while (!(File.EndOfStream))
                {
                    line = File.ReadLine();

                    if (line != "")
                    {
                        string[] array = line.Split(',');

                        List<string> list = new List<string>();
                        list.Add(array[0]);
                        list.Add(array[1]);

                        for (int i = 2; i < array.Length - 1; i++)
                        {
                            if (array[i] != "")
                            {
                                list.Add(array[i]);
                            }
                        }

                        Message1.Add(list);
                    }
                }
                result = true;
                File.Close();
            }
            return result;
        }


    }
}
