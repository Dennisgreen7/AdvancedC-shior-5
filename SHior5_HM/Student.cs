using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHior5_HM
{
    class SortStudentsByGradeDec : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (x.Grade.CompareTo(y.Grade) * -1);
        }
    }
    class SortStudentsByLastAndFirstNameAndGradeDec : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.LastName.CompareTo(y.LastName) == 0)
            {
                if(x.FirstName.CompareTo(y.FirstName)==0)
                {
                    return (x.Grade.CompareTo(y.Grade) * -1);
                }
                return x.FirstName.CompareTo(y.FirstName);
            }
            return x.LastName.CompareTo(y.LastName);
        }
    }
    class SortStudentsByGradeAsc : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (x.Grade.CompareTo(y.Grade) * 1);
        }
    }
    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
    }
}
