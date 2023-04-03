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
        public int KlasID;
        public string Fullname;
        public string Email;
        public string Password;

        public User(int id, int klasid, string fullname, string email, string password)
        {
            ID = id;
            KlasID = klasid;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
    }
}
