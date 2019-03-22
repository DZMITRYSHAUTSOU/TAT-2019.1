using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class EnteryPoint
    {
        static void Main(string[] args)
        {
            //Employee lead = new Lead();
            //Employee jun = new Junior();
            //Employee mid = new Middle();
            //Employee sen = new Senior();
            //Console.WriteLine(lead.getCost());
            //Console.WriteLine(jun.getCost());
            //Console.WriteLine(mid.getCost());
            //Console.WriteLine(sen.getCost());
            Company a = new Company();
            Option ex = new Option();
            ex.ExampleListBuild();
            ex.ChooseOption(a.WorkersCounter());
            ex.GetTeam();
            //Console.WriteLine(a.NetWorth());
            Console.ReadKey();
        }
    }
}
