using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        public T Element { get; set; }

        public void ToString() 
        {
            Console.WriteLine($"{Element.GetType()}: {Element}");
        }
    }
}
