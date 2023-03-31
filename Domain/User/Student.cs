using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Student : User
    {

        public Student(int id, string name, string password, string email)
        : base(id, name, password, email) { }
    }
}
