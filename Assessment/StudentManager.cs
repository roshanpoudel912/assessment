using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class StudentManager
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);

        }

        public void RemoveStudent(int id)
        {
            Boolean found = false;
            foreach (Student student in students.ToList())
            {
      
                if(student.Id == id)
                {
                    found = true;
                    students.Remove(student);

                }
               
            }

            if (found)
            {
                Console.WriteLine("Student found and removed from list");
            }
            else
            {
                Console.WriteLine($"Student id {id} not found");

            }

        }

        public void DisplayStudents()
        {
            foreach(Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine($"ID:{student.Id}"); ;
                Console.WriteLine($"Name:{student.Name}");
                Console.WriteLine($"Age:{student.Age}");
                Console.WriteLine($"Grades");
                foreach (double grade in student.grades)
                {
                    Console.WriteLine(grade);

                }
                Console.WriteLine($"Average:{student.CalculateAverageGrade()}");
            }
           

        }
    }
}
