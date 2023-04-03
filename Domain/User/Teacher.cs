using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Teacher : User
    {
<<<<<<< HEAD

        public Teacher(int id, string name, string password, string email)
            :base(id, name, password, email) {}
=======
        public Teacher(int id, int klasid, string fullname, string email, string password)
        : base(id, klasid, fullname, email, password) { }
>>>>>>> StudentBranch
    }
}
