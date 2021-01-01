using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char process = char.Parse(Console.ReadLine());
            double result = 0;
            string evenORodd = "a";

            switch (process)
            {
                case '+':
                    result = N1 + N2;
                    break;
                case '-':
                    result = N1 - N2;
                    break;
                case '*':
                    result = N1 * N2;
                    break;
                case '/':
                    result = N1 / N2;
                    break;
                case '%':
                    result = N1 % N2;
                    break;
            }

            if (process == '+' || process == '-' || process == '*')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");

                }
                else
                {
                    if (result % 2 == 0)
                    {
                        evenORodd = "even";
                    }
                    else
                    {
                        evenORodd = "odd";
                    }
                    Console.WriteLine($"{N1} {process} {N2} = {result} - {evenORodd}");
                }
            }
            if (process == '/')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");

                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
            }
            if (process == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");

                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
            }
            //if (N2 == 0)
            //{
            //    if (N2 == 0)
            //    {
            //        Console.WriteLine($"Cannot divide {N1} by zero");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"Cannot divide {N1} by zero");
            //    }
            //}

        }
    }
}
