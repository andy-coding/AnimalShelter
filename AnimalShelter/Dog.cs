using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Dog
    {
        private int age;

        public string Name;

        public Dog(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
    }
}
