using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Junior : Employee
    {
        public Junior()
        {
            cost *= 1;
            productivity *= 1;
        }
        public override string GetName()
        {
            return "Junior";
        }
    }
    
}
