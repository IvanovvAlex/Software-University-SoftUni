using System;
using System.Diagnostics.Tracing;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
               password += username[i];
            }

            string command = Console.ReadLine();
            int counter = 1;
            while (command != password)
            {
                string secondCommand = command;
                if (counter != 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
