using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                try
                {
                    list[key].Add(grade);
                }
                catch (Exception)
                {
                    list.Add(key, new List<double>());
                    list[key].Add(grade);
                }
            }

          

            foreach (var student in list.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }

           
        }
    }
}
