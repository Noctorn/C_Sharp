using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1
{
    internal class Student : Person
    {
        private String _name { get; set; }
        private int _age;
        private int _id;

        public Student()
        {
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return (int)_age; }
            set { _age = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override void personality()
        {
            Console.WriteLine("He has a good personaltiy");
        }
        public void display()
        {
            Console.WriteLine($"The name of the student is {Name} Id: {Id} Age:{Age}");
            Console.WriteLine($"Gender:{Gender} Date of birth: {Birthday}");
            Console.WriteLine();
            
        }

        public Student(string name, int age, int id)
        {
            this._name = name;
            this._age = age;
            this._id = id;
        }

    }
}
