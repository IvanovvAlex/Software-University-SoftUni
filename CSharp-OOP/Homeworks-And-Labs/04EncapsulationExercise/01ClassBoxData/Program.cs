using System;
using System.Runtime.Serialization;

namespace _01ClassBoxData
{
    public class StartUp
    {        
        public static void Main(string[] args)
        {            
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            
            
        }
    }
}
