using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Lead : Employee
    {
        public Lead()
        {
            cost *= 8;
            productivity *= 27;
        }
        public override string GetName()
        {
            return "Lead";
        }
    }
}
