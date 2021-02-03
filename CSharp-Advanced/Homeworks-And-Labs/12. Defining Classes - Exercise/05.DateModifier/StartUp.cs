using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
