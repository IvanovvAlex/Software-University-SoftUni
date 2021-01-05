using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();
            bool range = Range(password);
            bool consist = Consist(password);
            bool digits = Digits(password);

            if (range == true && consist == true && digits == true)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            if (range != true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (consist != true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digits != true)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        static bool Range(string password)
        {
            bool range = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                range = true;
            }
            return range;
        }

        static bool Consist(string password)
        {
            bool consist = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    consist = true;
                }
                else if (password[i] >= 97 && password[i] <= 122)
                {
                    consist = true;
                }
                else
                {
                    consist = false;
                    break;
                }
            }
            return consist;
        }

        static bool Digits(string password)
        {
            bool consist = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                consist = true;
            }
            return consist;
        }
    }
}
