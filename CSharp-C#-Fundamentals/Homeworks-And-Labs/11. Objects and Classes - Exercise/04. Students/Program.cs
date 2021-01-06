using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(line[0], line[1], double.Parse(line[2]));
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(n => n.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string secondName, double grade) 
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
    }
}
