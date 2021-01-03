using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            string nameOfBiggestKeg = String.Empty;
            double maxVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string nameOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    nameOfBiggestKeg = nameOfKeg;
                }
            }
            Console.WriteLine(nameOfBiggestKeg);
        }
    }
}
