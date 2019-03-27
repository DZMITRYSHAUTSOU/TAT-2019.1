using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Seminar : Materials
    {
        public string TaskList { get; set; }
        public  string Questions { get; set; }
        public string Answers { get; set; }
        public Seminar()
        {
            id = id.GetId();
        }
        public override string ToString()
        {
            return "Contains tasks and questions with answers.";
        }
    }
}