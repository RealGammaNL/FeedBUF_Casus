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
        public User(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
