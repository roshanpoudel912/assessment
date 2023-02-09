using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public List<double> grades = new List<double>();

        public double CalculateAverageGrade()
        {
            return grades.Average();
        }

    }
}
