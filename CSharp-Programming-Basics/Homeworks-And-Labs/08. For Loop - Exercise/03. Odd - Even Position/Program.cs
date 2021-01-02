using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var Oddsum = 0d;
            var Oddmax = double.MinValue;
            var Oddmin = double.MaxValue;
            var Esum = 0d;
            var Emax = double.MinValue;
            var Emin = double.MaxValue;


            if (num == 0)
            {
                Console.WriteLine("OddSum={0:f2},", num);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0:f2},", num);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");


            }
            else if (num == 1)
            {
                var curr = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0:f2},", curr);
                Console.WriteLine("OddMin={0:f2},", curr);
                Console.WriteLine("OddMax={0:f2},", curr);
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {

                    var curr = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        Oddsum = Oddsum + curr;
                        if (curr > Oddmax)
                        {
                            Oddmax = curr;
                        }
                        if (curr < Oddmin)
                        {
                            Oddmin = curr;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        Esum = Esum + curr;
                        if (curr > Emax)
                        {
                            Emax = curr;
                        }
                        if (curr < Emin)
                        {
                            Emin = curr;
                        }
                    }
                }

                Console.WriteLine("OddSum={0:f2},", Oddsum);
                Console.WriteLine("OddMin={0:f2},", Oddmin);
                Console.WriteLine("OddMax={0:f2},", Oddmax);
                Console.WriteLine("EvenSum={0:f2},", Esum);
                Console.WriteLine("EvenMin={0:f2},", Emin);
                Console.WriteLine("EvenMax={0:f2}", Emax);

            }
        }
    }
}
