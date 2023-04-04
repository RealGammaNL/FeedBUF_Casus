using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class User
    {
        public int ID;
        public string GroupID;
        public string Fullname;
        public string Email;
        public string Password;

        public User(int id, string groupid, string fullname, string email, string password)
        {
            ID = id;
            GroupID = groupid;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
    }
}
