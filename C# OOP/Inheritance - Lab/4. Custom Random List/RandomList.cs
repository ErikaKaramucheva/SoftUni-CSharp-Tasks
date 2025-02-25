using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Lab._4._Custom_Random_List
{
    internal class RandomList : List<string>
    {
        Random random = new Random();
        public string RandomString()
        {
            string temp;
            int index = random.Next(0, this.Count);
            temp = this[index];
            this.RemoveAt(index);
            return temp;
        }
    }
}
