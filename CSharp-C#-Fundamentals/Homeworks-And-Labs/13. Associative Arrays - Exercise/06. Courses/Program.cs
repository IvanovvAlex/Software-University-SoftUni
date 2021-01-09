using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCommand = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var list = new Dictionary<string, List<string>>();
            

            while (firstCommand[0] != "end")
            {
                string[] command = firstCommand;

                string course = command[0];
                string name = command[1];

                if (list.ContainsKey(course))
                {
                    list[course].Add(name);
                   
                    
                }
                else
                {
                    list.Add(course, new List<string>());
                    list[course].Add(name);
                   
                    
                }

                firstCommand = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var item in list)
            {
                item.Value.Sort();
            }


            foreach (var course in list
               .OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                        
                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
