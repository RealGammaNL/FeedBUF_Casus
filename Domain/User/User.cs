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
        public string Name;
        public string Password;
        public string Email;

        public User(int id, string name, string password, string email)
        {
            ID = id;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
