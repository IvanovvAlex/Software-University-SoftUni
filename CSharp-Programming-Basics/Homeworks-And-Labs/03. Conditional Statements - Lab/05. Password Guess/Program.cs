using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredpass = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (enteredpass == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
