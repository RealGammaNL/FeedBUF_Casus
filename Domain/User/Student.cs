using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Student : User
    {

        public Student(int id, string groupid, string fullname, string email, string password)
        : base(id, groupid, fullname, email, password) { }

    }
}
