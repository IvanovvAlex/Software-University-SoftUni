using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Student> students = new List<Student>();
            List<string> names = new List<string>();

            while (startCommand[0] != "end")
            {
                string[] command = startCommand;

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string hometown = command[3];

                if (names.Contains(firstName + " " + lastName))
                {
                    foreach (Student student in students)
                    {
                        Student existingStudent = null;
                        if (student.FirstName == firstName && student.LastName == lastName)
                        {
                            existingStudent = student;
                            existingStudent.Age = age;
                        }
                    }
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;

                    students.Add(student);
                    names.Add(firstName + " " + lastName);
                }
             

                

                startCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string town = Console.ReadLine();

            foreach (Student student in students.Where(s => s.Hometown == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
