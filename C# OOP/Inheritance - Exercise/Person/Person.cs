using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Exercise.Person
{
    internal class Person
    {
        public int Age { get; set; }
        string Name { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            if (age <0)
            {
                throw new ArgumentException(message: "Age must be positive.");
            }
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: "+this.Name + ", Age: "+this.Age);
            return sb.ToString();
        }


    }
}
