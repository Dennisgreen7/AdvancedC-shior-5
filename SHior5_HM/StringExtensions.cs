using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    public static class StringExtensions
    {
        public static bool HasLowerChars(this string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToLower())
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string ReverseCase(this string str)
        {
            string ReverseStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToLower())
                {
                    ReverseStr += str[i].ToString().ToUpper();
                }
                else
                {
                    ReverseStr += str[i].ToString().ToLower();
                }
            }
            return ReverseStr;
        }
        public static bool IsValidIsraeliNumber(this string tz)
        {
            if (tz.Length != 9)
            {
                Console.WriteLine("Tz should be 9 numbers");
                return false;
            }

            int res = 0;

            for (int i = 1; i < 8; i += 2)
            {
                res += int.Parse(tz[i - 1].ToString()) + ((int.Parse(tz[i].ToString()) * 2) / 10) + ((int.Parse(tz[i].ToString()) * 2) % 10);
            }
            if ((res + int.Parse(tz[8].ToString())) % 10 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
