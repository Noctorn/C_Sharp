using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{   
    abstract class Animal
    { 
        public abstract void animalSound(); 
        public void sleeps()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Cats does Meow");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dogs does Woof Woof");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.animalSound();
            c.sleeps();
            Dog dog = new Dog();
            dog.animalSound();
            dog.sleeps();
            Console.ReadKey();  
        }
    }
}
