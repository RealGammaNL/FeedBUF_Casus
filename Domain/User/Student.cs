using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Student : User
    {
        Student(int id, string name) 
        :base (id, name) { }
    }
}
