using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    public static class IntExtensions
    {
        public static string NumberToWords(this int number)
        {
            if (number > 100)
                return "Ad Kan!";

            if (number == 100)
                return "One-Hundrend";

            if (number == 0)
                return "zero";

            string words = "";

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        public static long Hezka(this int number, int num)
        {
            long res = 1;
            for (int i = 0; i < num; i++)
            {
                res *= number;
            }
            return res;
        }
        public static long MultipleBy(this int number, int num)
        {
            return number * num;
        }

    }
}
