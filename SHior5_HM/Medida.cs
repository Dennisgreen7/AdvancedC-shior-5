using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    class SortMedidaByTempDscAndCityAsc : IComparer<Medida>
    {
        public int Compare(Medida x, Medida y)
        {
            if (x.Temp.CompareTo(y.Temp) * -1 == 0)
            {
                return (x.City.CompareTo(y.City));
            }
            return (x.Temp.CompareTo(y.Temp) * -1);
        }
    }
    class SortMedidaByLahotDsccAndTempAscAndCityAsc : IComparer<Medida>
    {
        public int Compare(Medida x, Medida y)
        {
            if (x.Lahot.CompareTo(y.Lahot) * -1 == 0)
            {
                if (x.Temp.CompareTo(y.Temp) * -1 == 0)
                {
                    return (x.City.CompareTo(y.City));
                }
                else
                {
                    return x.Temp.CompareTo(y.Temp) * -1;
                }
            }
            return x.Lahot.CompareTo(y.Lahot) * -1;
        }
    }
    class Medida : IComparable<Medida>
    {
        public string City { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Temp { get; set; }
        public int Lahot { get; set; }

        public Medida(string city, int temp)
        {
            City = city;
            Temp = temp;
        }

        public int CompareTo(Medida other)
        {
            if (this.City.CompareTo(other.City) == 0)
            {
                return this.Date.CompareTo(other.Date);
            }
            return this.City.CompareTo(other.City);
        }
    }
}
