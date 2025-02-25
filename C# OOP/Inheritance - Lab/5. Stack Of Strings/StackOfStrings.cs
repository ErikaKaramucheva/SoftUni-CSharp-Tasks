using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Lab._5._Stack_Of_Strings
{
    internal class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stack<string> AddRange(List<string> strings)
        {
            foreach (string s in strings)
            {
                this.Push(s);
            }
            return this;
        }
    }
}
