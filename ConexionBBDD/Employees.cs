using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD
{
    public partial class Employees
    {
        public string first_name { get; set; }
        public string last_name { get; set; }

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
