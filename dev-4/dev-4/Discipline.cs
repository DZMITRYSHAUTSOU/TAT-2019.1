using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Discipline
    {
        public string id=Identifier.GetId();
        public List<Lection> lections = new List<Lection>();        
        public override string ToString()
        {
            return "Discipline example descryption";
        }
        public void NewLection(int n)
        {
            for(int i=0;i<n;i++)
            {
                lections.Add(new Lection());
            }
        }
    }
}
