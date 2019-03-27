using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class LaboratoryPractice : Materials//no variables for this class listed in task
    {
        public LaboratoryPractice()
        {
            id = id.GetId();
        }
        public override string ToString()
        {
            return "Contains materials for laboratory lessons.";
        }
    }
}
