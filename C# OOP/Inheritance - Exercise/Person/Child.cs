using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Exercise.Person
{
    internal class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (age > 15)
            {
                throw new ArgumentException("Children cannot be above 15 years old.");
            }
        }
       
    }

}
