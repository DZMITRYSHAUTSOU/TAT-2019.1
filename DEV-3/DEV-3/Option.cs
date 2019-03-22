using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Option
    {
        private float summ=1000;
        private Company ex = new Company();
        private List<Employee> Team = new List<Employee>();
        private List<Employee> Exw = new List<Employee>();
        private int[] TeamCounter = new int[4];
        public void ExampleListBuild()
        {
            Exw.Add(new Lead());
            Exw.Add(new Senior());
            Exw.Add(new Middle());
            Exw.Add(new Junior());
        }
        public Option()
        {

        }
        public void setSumm(float value)
        {
            summ = value;
        }
        public void ChooseOption(List<int> workerscounter)
        {
            int option = 0;
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    setSumm(int.Parse(Console.ReadLine()));
                    if (ex.NetWorth() < summ)
                    {
                        Console.WriteLine("Workers total cost is " + ex.NetWorth() + " !");
                    }
                    if (summ <= 0)
                    {
                        Console.WriteLine("Incorrect summ");
                    }
                    break;
                case 2:
                    int counter;
                    for (int i = 0; i < 4; i++)
                    {
                        counter = 1;
                        while(summ>0 && summ>Exw[i].getCost() && counter<=workerscounter[i])
                        {
                            Team.Add(Exw[i]);
                            TeamCounter[i]++;
                        }
                    }
                    break;
            }
        }
        public void GetTeam()
        {
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(TeamCounter[i] + "  " + Exw[i].GetName());
            }
        }
    }
            
}
