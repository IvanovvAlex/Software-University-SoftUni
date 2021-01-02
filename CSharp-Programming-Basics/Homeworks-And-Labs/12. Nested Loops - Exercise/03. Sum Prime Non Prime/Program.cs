using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int counter = 0;
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 1)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
