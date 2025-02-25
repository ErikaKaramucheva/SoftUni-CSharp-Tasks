using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Kittens : Cat
    {
        public Kittens(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
