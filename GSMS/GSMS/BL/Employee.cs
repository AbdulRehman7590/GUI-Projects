using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMS.DL;
using GSMS.Enums;

namespace GSMS.BL
{
    public class Employee : User
    {

        public Employee(UserType role, string userName, string password, string contact) : base(role, userName, password, contact)
        {
        }



    }
}
