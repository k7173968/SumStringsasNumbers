using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStringsasNumbers
{
    class SumStringsasNumbers
    {
        public string kata(string str1, string str2)
        {
            if(str1=="" || str2=="")
            {
                string sumString = str1 + str2;
                return String.Concat(Convert.ToInt32(sumString));
            }
            return String.Concat(Convert.ToInt32(str1) + Convert.ToInt32(str2));
        }
    }
}
