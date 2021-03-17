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
            Height = height;
        }               
        public double Length
        {
            get { return length; }
            private set 
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }
        public void SurfaceArea()
        {
            double result = (2d * Length * Width)+(2d * Length * Height)+(2d * Width * Height);
            Console.WriteLine($"Surface Area - {result:f2}");
        }
        public void LateralSurfaceArea()
        {
            double result = (2 * length * height) + (2 * width * height);
            Console.WriteLine($"Lateral Surface Area - {result:f2}");
        }
        public void Volume()
        {
            double result = length * height * width;
            Console.WriteLine($"Volume - {result:f2}");
        }
    }
}
