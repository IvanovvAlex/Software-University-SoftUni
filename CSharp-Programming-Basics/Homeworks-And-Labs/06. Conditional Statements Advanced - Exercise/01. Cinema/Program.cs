using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            int full = r * c;
            double income = -1.0;

            switch (type)
            {
                case "premiere":
                    income = full * 12.0;
                    break;

                case "normal":
                    income = full * 7.5;
                    break;

                case "discount":
                    income = full * 5.0;
                    break;
            }
            Console.WriteLine("{0:f2} leva", income);

        }
    }
}
