using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int currentAge = int.Parse(line[1]);
                people[i] = new Person();
                people[i].Name = name;
                people[i].Age = currentAge;

            }
            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            Func<Person, bool> condition = GetAgeCondition(filter, filterAge);

            Action<Person> formatter = GetFormatter(Console.ReadLine());

            PrintPeople(people, condition, formatter);
        }
        static Action<Person> GetFormatter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetAgeCondition(string filter,
            int filterAge)
        {
            switch (filter)
            {
                case "younger": return p => p.Age < filterAge;
                case "older": return p => p.Age >= filterAge;
                default:
                    return null;
            }
        }

        static void PrintPeople(Person[] people,
            Func<Person, bool> condition, Action<Person> formatter)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    formatter(person);
                }
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
