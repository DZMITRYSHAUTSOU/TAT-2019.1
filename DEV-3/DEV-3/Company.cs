using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Company
    {
        protected int juns = 30;
        protected int mids = 12;
        protected int sens = 8;
        protected int leads = 3;
        protected float networth = 0;
        protected List<Employee> workers=new List<Employee>();
        protected List<int> WorkersCount = new List<int>();
        public List<int> WorkersCounter()
        {
            WorkersCount.Add(leads);
            WorkersCount.Add(sens);
            WorkersCount.Add(mids);
            WorkersCount.Add(juns);
            return WorkersCount;
        }
        public List<Employee> getList()
        {
            return workers;
        }
        public float NetWorth()
        {
            for (int i = 0; i < juns; i++)
            {
                workers.Add(new Junior());
            }
            if (juns!=0)
            {
                networth += workers[0].getCost() * juns;
            }
            for (int i = 0; i < mids; i++)
            {
                workers.Add(new Middle());
            }
            if (mids != 0)
            {
                networth += workers[juns].getCost() * mids;
            }
            for (int i = 0; i < sens; i++)
            {
                workers.Add(new Senior());
            }
            if (sens != 0)
            {
                networth += workers[juns + mids].getCost() * sens;
            }
            for (int i = 0; i < leads; i++)
            {
                workers.Add(new Lead());
            }
            if (sens != 0)
            {
                networth += workers[juns + mids + sens].getCost() * leads;
            }
            return networth;
        }
    }
}
