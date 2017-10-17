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
            if (str1 == "" || str2 == "")
            {
                string sumString = str1 + str2;
                return String.Concat(Convert.ToInt32(sumString));
            }
            var groupByString = this.sumTwoString(str1, str2);           
            return String.Concat(getFinalResult(groupByString)).TrimStart('0');
        }

        private List<int> getFinalResult(List<int> groupByString)
        {
            int isCarry;
            int emptySpace = 0;
            int toDecimal = 10;
            List<int> addTwoString = new List<int> { };
            foreach (var element in groupByString)
            {
                isCarry = element + emptySpace;
                emptySpace = 0;
                if (isCarry >= toDecimal)
                {
                    addTwoString.Add(isCarry % toDecimal);
                    emptySpace = isCarry / toDecimal;
                }
                else
                {
                    addTwoString.Add(isCarry);
                }
            }

            if (emptySpace != 0)
            {
                addTwoString.Add(emptySpace);
            }
            addTwoString.Reverse();
            return addTwoString;
        }

        private List<int> sumTwoString(string str1, string str2)
        {
            string newString;
            string orignString;
            if (Math.Abs(str1.Length - str2.Length) != 0)
            {
                newString = Math.Min(str1.Length, str2.Length) == str1.Length ? str1 : str2;
                orignString = Math.Max(str1.Length, str2.Length) == str1.Length ? str1 : str2;
                for (int i = 1; i <= Math.Abs(str1.Length - str2.Length); i++)
                {
                    newString = "0" + newString;
                }
            }
            else
            {
                newString = str1;
                orignString = str2;
            }
            var groupByString = newString.Select(b => (int) Char.GetNumericValue(b))
                .Zip(orignString.Select(b => (int) Char.GetNumericValue(b)), (x, y) => x + y).Reverse().ToList();
            return groupByString;
        }
    }
}
