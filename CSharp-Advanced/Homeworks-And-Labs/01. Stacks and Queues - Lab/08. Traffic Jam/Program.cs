using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenPass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "green")
                {
                    passedCars += greenPass;
                    for (int i = 0; i < greenPass; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!"); 
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
