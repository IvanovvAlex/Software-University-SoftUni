using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int start = 1;

            for (int rows = 1; rows <= num; rows++)
            {
                
                for (int cows = 1; cows <= start; cows++)
                {
                    Console.Write(start + " ");
                    
                }
                Console.WriteLine();
                start++;
            }
        }
    }
}
