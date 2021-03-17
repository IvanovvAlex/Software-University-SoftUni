using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public Cake(string name)
          : base(name, 5m, 250.0, 1000.0)
        {

        }
    }
}
