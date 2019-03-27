using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Seminar : Materials
    {
        public List<string> Tasks = new List<string>();
        public List<string> questions = new List<string>();
        public List<string> answers = new List<string>();
        public override string ToString()
        {
            return "Contains tasks and questions with answers.";
        }
    }
}
