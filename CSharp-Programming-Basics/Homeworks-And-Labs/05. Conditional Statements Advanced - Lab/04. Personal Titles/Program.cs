using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();
            if (age < 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (sex == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else if (age >= 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (sex == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
