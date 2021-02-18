using System;
using System.Collections.Generic;
using System.Linq;

namespace Ali
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vanka = new List<int>();
            vanka.Add(5);
            vanka.Remove(5);
            Console.WriteLine(string.Join(" ", vanka));

        }
    }
}
