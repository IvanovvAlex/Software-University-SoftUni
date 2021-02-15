using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                Box<string> box = new Box<string>();
                box.Element = line;
                box.ToString();
            }
        }
    }
}
