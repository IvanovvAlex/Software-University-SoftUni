using System;

namespace _02.GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int line = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>();
                box.Element = line;
                box.ToString();
            }
        }
    }
}
