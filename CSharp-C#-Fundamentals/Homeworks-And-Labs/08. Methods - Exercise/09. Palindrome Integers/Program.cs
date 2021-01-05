using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                int commandToNum = int.Parse(command);
                bool trueOrNot = false;
                int reversedNum = ReversedNum(commandToNum);
                if (commandToNum == reversedNum)
                {
                    trueOrNot = true;
                }
                Console.WriteLine(trueOrNot
                    .ToString()
                    .ToLower());
                command = Console.ReadLine();
            }
        }

         static int ReversedNum(int commandToNum)
        {
            
            int reversedNum = 0;
            while (Convert.ToBoolean(commandToNum))
            {
                int r = commandToNum % 10;
                reversedNum = reversedNum * 10 + r;
                commandToNum = commandToNum / 10; 
            }
            return reversedNum;
        }
    }
}
