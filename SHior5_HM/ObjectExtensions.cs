using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    public static class ObjectExtensions
    {
        public static bool isNull<T>(this T obj) where T :class
        {
            if (obj is null)
            {
                return true;
            }
            return false;
        }
    }
}
