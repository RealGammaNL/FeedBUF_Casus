using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Teacher : User
    {
        public Teacher(int id, string name)
        : base(id, name) { }
    }
}
