using System;
using System.Collections.Generic;
using System.Text;

namespace _01ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Length = length;
        }               
        public double Length
        {            
            
            private set 
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    return;
                }
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    return;
                }
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    return;
                }
            }
        }
        public void SurfaceArea()
        {
            Console.WriteLine($"Surface Area - {((2*length*width)+(2*length*height)+(2*width*height)):f2}");
        }
        public void LateralSurfaceArea()
        {
            Console.WriteLine($"Lateral Surface Area - {((2*length*height)+(2*width*height)):f2}");
        }
        public void Volume()
        {
            Console.WriteLine($"Volume - {(length*height*width):f2}");
        }
    }
}
