using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string realPassword = Console.ReadLine();

            string password = Console.ReadLine();

            while (true)
            {
                if (password == realPassword)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
                password = Console.ReadLine();
            }
        }
    }
}
