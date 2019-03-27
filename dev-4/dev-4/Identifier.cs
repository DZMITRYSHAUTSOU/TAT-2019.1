using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Identifier
    {
        public static string GetId()
        {
            Guid id = Guid.NewGuid();
            return (id.ToString()); 
        }
    }
}
