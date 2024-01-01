using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Animal
    {
        void animalSound(); void sleeps();
    }
    class Cat:Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Cat does Meow Meow");
        }
        public void sleeps()
        {
            Console.WriteLine("Zzzzz");
        }
    }
    
    class Dog : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Dog does Woof Woof");
        }
        public void sleeps()
        {
            Console.WriteLine("Zzz");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();    
            cat.animalSound();
            cat.sleeps();
            dog.animalSound();
            dog.sleeps();

            Console.ReadKey();
        }
    }
}
