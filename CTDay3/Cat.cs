using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay3
{
    internal class Cat
    {
        public int Age { get; set; } //Cannot be larget than 25

        public Cat(int age)
        {
            if (age > 25) throw new CatAgeException("Cat age cannot be larger than 25");
            Age = age;
        }

        public void PrintAge()
        {
            Console.WriteLine(Age);
            return;
        }
    }
}
