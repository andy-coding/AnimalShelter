using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {
        static void Main()
        {
            AnimalShelter dogsShelter = new AnimalShelter(10);
            Dog dog1 = new Dog("Jackie", 1);
            Dog dog2 = new Dog("Lassy", 2);
            Dog dog3 = new Dog("Rex", 3);
            dogsShelter.Shelter(dog1);
            dogsShelter.Shelter(dog2);
            dogsShelter.Shelter(dog3);
            dogsShelter.Release(1);
            Console.WriteLine("Dog: {0} released.", dog2.Name); // Releasing dog2
        }
    }
}

