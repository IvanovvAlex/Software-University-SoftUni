using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{    
        public class Box<T> where T : IComparable
        {
            private List<T> values;

            public Box()
            {
                this.values = new List<T>();
            }

            public void Add(T value)
            {
                this.values.Add(value);
            }
        public int GetGreaterElementsCount(T value)
        {
            CheckIfEmpty();

            int counter = 0;

            foreach (var item in this.values)
            {
                if (item.CompareTo(value) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void Swap(int firstIndex, int secondIndex)
            {
                CheckIfEmpty();
                CheckIndexOutOfRange(firstIndex, secondIndex);

                var temp = this.values[firstIndex];
                this.values[firstIndex] = this.values[secondIndex];
                this.values[secondIndex] = temp;
            }

            public override string ToString()
            {
                var result = new StringBuilder();

                foreach (var value in this.values)
                {
                    result.AppendLine($"{value.GetType()}: {value}");
                }

                return result.ToString();
            }

            private void CheckIfEmpty()
            {
                if (this.values.Count == 0)
                {
                    throw new InvalidOperationException("Collection is empty!");
                }
            }

            private void CheckIndexOutOfRange(int firstIndex, int secondIndex)
            {
                if (firstIndex < 0 || firstIndex >= this.values.Count
                                || secondIndex < 0 && secondIndex >= this.values.Count)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }    
}
