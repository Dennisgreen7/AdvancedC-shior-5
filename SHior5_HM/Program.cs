using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    class Program
    {
        static void Main(string[] args)
        {
            ////question 1
            List<Student> Students = new List<Student>();
            Students.Add(new Student("Avi", "Levi", 80));
            Students.Add(new Student("Cristiano", "Ronaldo", 100));
            Students.Add(new Student("Lionel", "Messi", 55));
            Students.Add(new Student("Dennis", "Greenberg", 90));
            Students.Sort();
            Students.Sort(new SortStudentsByGradeAsc());
            Students.Sort(new SortStudentsByLastAndFirstNameAndGradeDec());
            Students.Sort(new SortStudentsByGradeDec());
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i].FirstName + " " + Students[i].LastName + " " + Students[i].Grade);
            }
            //////question 2
            List<Medida> Medidot = new List<Medida>();
            Medidot.Add(new Medida("Madrid", 700));
            Medidot.Add(new Medida("Barcelona", 2));
            Medidot.Add(new Medida("Barcelona", 100));
            Medidot.Add(new Medida("Prague", -7));
            Medidot.Add(new Medida("London", 34));
            Medidot.Add(new Medida("Roma", 700));

            Medidot.Sort();
            Medidot.Sort(new SortMedidaByTempDscAndCityAsc());
            Medidot.Sort(new SortMedidaByLahotDsccAndTempAscAndCityAsc());
            for (int i = 0; i < Medidot.Count; i++)
            {
                Console.WriteLine(Medidot[i].City + " " + Medidot[i].Temp);
            }
            ////Extensions Methodes
            string str = "Dennis";
            bool res = str.HasLowerChars();
            string str2 = "DENNIS";
            bool res2 = str2.HasLowerChars();
            string res3 = str.ReverseCase();
            string res4 = str2.ReverseCase();
            //Console.WriteLine(res);//True
            //Console.WriteLine(res2);//False
            //Console.WriteLine(res3);//dENNIS
            //Console.WriteLine(res4);//DENNIS
            int num = 76;
            string strnum = num.NumberToWords();
            int num2 = 10;
            Console.WriteLine(strnum);
            string a = "0";
            bool ss = a.isNull();
            Console.WriteLine(ss);
            string tz = "315976233";
            Console.WriteLine(tz.IsValidIsraeliNumber());
            Console.WriteLine(num2.MultipleBy(10));
            Console.ReadLine();
        }
    }
}
