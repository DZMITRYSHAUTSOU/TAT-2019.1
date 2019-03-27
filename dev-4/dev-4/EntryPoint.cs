using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Discipline example = new Discipline();
            example.NewLection(2);
            example.lections[0].AddLabs(2);
            example.lections[1].SetFormat(2);
            Console.WriteLine(example.id);
            Console.WriteLine(example.lections[1].ToString());
            Console.ReadKey();
        }
    }
}
