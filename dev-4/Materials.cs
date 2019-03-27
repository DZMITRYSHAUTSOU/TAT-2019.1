using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Materials//overrided ToString() and Equals()
    {
        public string id;
        public override string ToString()
        {
            return "Example descryption.";
        }
        public override bool Equals(object obj)
        {
            Materials Mobj = (Materials) obj;
            return id==Mobj.id ? true : false;
        }
    }
}
