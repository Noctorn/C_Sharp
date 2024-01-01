using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Pig:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Oink Oink");
        }
    }
    class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
