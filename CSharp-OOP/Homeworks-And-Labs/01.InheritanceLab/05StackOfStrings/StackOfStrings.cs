using System;
using System.Collections.Generic;
using System.Text;

namespace _05StackOfStrings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            return false;
        }
        public Stack<string> AddRange(IEnumerable<string> range)
        {
            foreach (var item in range)
            {
                this.Push(item);
            }
            return this;
        }
    }
}
