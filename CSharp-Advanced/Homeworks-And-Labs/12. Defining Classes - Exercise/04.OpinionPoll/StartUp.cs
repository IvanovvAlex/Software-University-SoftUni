using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> list = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];
                int age = int.Parse(command[1]);
                list.Add(new Person(name, age));
            }

            foreach (var person in list.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
