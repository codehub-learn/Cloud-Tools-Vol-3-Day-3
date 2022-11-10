using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay3
{
    internal class GenericCatStack<T> where T: Cat
    {
        private int index = 0;
        private T[] stack = new T[10];

        public void Push(T item)
        {
            stack[index++] = item;
            Console.WriteLine(item.Age);
        }

        public T Pop()
        {
            return stack[index--];
        }
    }
}
