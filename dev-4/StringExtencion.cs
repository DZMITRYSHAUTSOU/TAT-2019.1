using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    public static class StringExtension//string extension for guid id
    {
        public static string GetId(this string str)
        {
            Guid id = Guid.NewGuid();
            return id.ToString();
        }
    }
}