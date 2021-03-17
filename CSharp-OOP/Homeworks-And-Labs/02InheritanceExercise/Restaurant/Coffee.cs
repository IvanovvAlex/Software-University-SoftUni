using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine)
            : base(name, 3.5m, 50.0)
        {
            Caffeine = caffeine;
        }     
        public double Caffeine { get; set; }       
       
    }
}
