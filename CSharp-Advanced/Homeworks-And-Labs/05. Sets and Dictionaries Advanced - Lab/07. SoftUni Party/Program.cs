using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                bool isDigit = char.IsDigit(input[0]);
                if (input.Length == 8 && isDigit == false)
                {
                    regularGuests.Add(input);
                }                
                
                if (isDigit)
                {
                    vipGuests.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
                input = Console.ReadLine();
            }            
                Console.WriteLine((vipGuests.Count + regularGuests.Count));
                foreach (var guest in vipGuests)
                {
                    Console.WriteLine(guest);
                }
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }                       
        }
    }
}
