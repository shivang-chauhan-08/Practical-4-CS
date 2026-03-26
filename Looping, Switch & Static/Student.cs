using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping__Switch___Static
{
    internal class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        public static decimal AverageMarks;

        public decimal CalculateAverageMarks()
        {
            decimal sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            AverageMarks = sum / Marks.Length;
            return AverageMarks;
        }

        public string CalculateGrade(decimal marks)
        {
            int mark = Convert.ToInt32(marks / 10);
            string grade;
            switch (mark)
            {
                case 10:
                case 9:
                    grade = mark == 9 ? "B" : "A";
                    break;
                case 8:
                    grade = mark == 8 ? "C" : "B";
                    break;
                case 7:
                    grade = mark == 7 ? "D" : "C";
                    break;
                default:
                    grade = "D";
                    break;
            }

            return grade;
        }
    }

    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
}
