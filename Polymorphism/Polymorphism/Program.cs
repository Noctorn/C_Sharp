using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.animalSound();
            Animal pig = new Pig();
            pig.animalSound();
            Animal dog = new Dog();
            dog.animalSound();
            Console.ReadKey (); 
        }
    }
}
