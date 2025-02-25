using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Cake : Dessert
    {
        public Cake(string name, decimal price, double grams, double calories) : base(name, price, grams, calories)
        {
            if(grams== 0)
            {
                this.Grams = 250;
            }
            if (calories == 0)
            {
                this.Calories = 1000;
            }
            if (price == 0)
            {
                this.Price = 5;
            }
        }
    }
}
