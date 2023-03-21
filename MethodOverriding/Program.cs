using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hi , here we use Method Overridng in c sharp, for that we take two classes , frist Parent class (Animal)
// then child class (as Dog) with inherit method. and we got out put of overridding method in consol.
// in overridding method we override parent class.

namespace MethodOverriding
{
    class Animal
    {

        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }

    class Dog:Animal
        {
            public void Eat()
            {
                Console.WriteLine("Dog is Eating");
            }

        }

            static void Main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
            Console.ReadLine();
        }
    }
}
