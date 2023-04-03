using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Student : User
    {
        public Student(int id, int klasid, string fullname, string email, string password)
        : base(id, klasid, fullname, email, password) { }
    }
}
