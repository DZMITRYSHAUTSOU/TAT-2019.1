using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class EntryPoint//Basically sandbox for testing objects and theire interactions
    {
        static void Main(string[] args)
        {
            Discipline example = new Discipline();
            example[0].AddLabs(2);
            example[0].AddSeminars(3);
            example[0].SetFormat(2);
            Console.WriteLine(example.id);
            Console.WriteLine(example.lections[1].ToString());
            Console.WriteLine(example[0].labs[0].ToString());
            example[0].LecText = "something";
            example[0].seminars[2].TaskList = "something else";
            Discipline example2 = new Discipline();
            example2.Clone(example);
            example2[0].AddLabs(2);
            example2[1].SetFormat(2);
            Console.WriteLine(example2.id);
            Console.WriteLine(example2.lections[1].ToString());
            Console.WriteLine(example[0].labs[0].ToString());
            Console.WriteLine(example.Equals(example2));
            Console.WriteLine(example[0].LecText);//Clone check
            Console.WriteLine(example2[0].LecText);//
            Console.WriteLine(example[0].seminars[2].TaskList);
            Console.WriteLine(example[0].GetFormat());
        }
    }
}
