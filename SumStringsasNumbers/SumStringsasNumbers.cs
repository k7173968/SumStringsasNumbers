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
            if (str1 == "" || str2 == "" || str1.Length!=str2.Length)
                return "000";
            var groupByString = str1.Select(b => (int)Char.GetNumericValue(b)).Zip(str2.Select(b => (int)Char.GetNumericValue(b)), (x, y) => x + y).ToList();
            return  String.Concat(groupByString);
        }
    }
}
