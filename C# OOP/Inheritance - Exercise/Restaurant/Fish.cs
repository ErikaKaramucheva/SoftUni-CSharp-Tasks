using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Fish : MainDish 
    {

        public Fish(string name, decimal price, double grams) : base(name, price, grams)
        {
            if (grams == 0)
            {
                this.Grams = 22;
            }
        }
    }
}
