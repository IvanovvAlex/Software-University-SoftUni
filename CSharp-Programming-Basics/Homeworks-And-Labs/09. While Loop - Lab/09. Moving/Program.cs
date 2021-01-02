using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int freespace = width * length * hight;
            int totalSpace = 0;
            int spaceDiff = 0;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int cartoonSpace = int.Parse(command);

                totalSpace = totalSpace + cartoonSpace;
                spaceDiff = Math.Abs(totalSpace - freespace);
                if (totalSpace > freespace)
                {
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", spaceDiff);
                    break;
                }


                command = Console.ReadLine();

            }
            if (command == "Done")
            {
                Console.WriteLine("{0} Cubic meters left.", spaceDiff);
            }
        }
    }
}
