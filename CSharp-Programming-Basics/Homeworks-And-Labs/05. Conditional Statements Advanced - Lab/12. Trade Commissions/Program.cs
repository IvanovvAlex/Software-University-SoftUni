using System;

namespace Trade_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var comision = -1.0;

            if (city == "sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comision = 0.05;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comision = 0.07;
                }
                else if (1000 < sales && sales < 10000)
                {
                    comision = 0.08;
                }
                else if (sales > 10000.0)
                {
                    comision = 0.12;
                }
            }
            if (city == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comision = 0.045;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comision = 0.075;
                }
                else if (1000 < sales && sales < 10000)
                {
                    comision = 0.10;
                }
                else if (sales > 10000.0)
                {
                    comision = 0.13;
                }
            }

            if (city == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comision = 0.055;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comision = 0.08;
                }
                else if (1000 < sales && sales < 10000)
                {
                    comision = 0.12;
                }
                else if (sales > 10000.0)
                {
                    comision = 0.145;
                }
            }
            if (comision >= 0)
            {
                Console.WriteLine("{0:f2}", sales * comision);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
