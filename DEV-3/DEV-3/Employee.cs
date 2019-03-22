using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Employee
    {
        public static int counter = 0;
        protected float cost = 100;
        protected float productivity = 1;
        public virtual string GetName()
        {
            return "Employee";
        }
        public float getCost()
        {
            return cost;
        }
        public float getProductivity()
        {
            return productivity;
        }
        public void setCost(float value)
        {
            cost = value;
        }
        public void setProductivity(float value)
        {
            productivity = value;
        }
    }
}
