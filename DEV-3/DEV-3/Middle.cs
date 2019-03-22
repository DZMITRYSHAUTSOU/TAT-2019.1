using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Middle : Employee
    {
        public Middle()
        {
            cost *= 2;
            productivity *= 3;
        }
        public override string GetName()
        {
            return "Middle";
        }
    }
}
