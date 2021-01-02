using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            var end = true;

            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine().ToLower();
                if (site == "facebook")
                {
                    salary -= 150;
                }
                if (site == "instagram")
                {
                    salary -= 100;
                }
                if (site == "reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    end = false;
                    break;
                }
            }
            if (!end)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
