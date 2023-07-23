using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GSMS.Enums;
using GSMS.DL;

namespace GSMS.BL
{
    public class User
    {
        private UserType role;
        private string userName;
        private string password;
        private string contact;


        public UserType Role { get => role; set => role = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Contact { get => contact; set => contact = value; }


        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public User(UserType role, string userName, string password, string contact)
        {
            this.Role = role;
            this.UserName = userName;
            this.Password = password;
            this.Contact = contact;
        }

        public string GetName()
        {
            return this.UserName;
        }

        public string GetPass()
        {
            return this.Password;
        }

        public UserType GetRole()
        {
            return this.Role;
        }

        public void SetPass(string password)
        {
            this.Password = password;
        }

        public string GetContact()
        {
            return this.Contact;
        }



        public void ChangePass(string pass)
        {
            SetPass(pass);
            UserDL.StoreUsersData();
        }





    }
}
