using System;
using GSMS.Enums;

namespace GSMS.BL
{
    public class Admin : User
    {

        public Admin(UserType role, string userName, string password, string contact) : base(role, userName, password, contact)
        {
        }

    }
}
