using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Oops1
{
    internal class Person
    {
        private String _gender;
        private DateTime _dob;

        public String Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public DateTime Birthday
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public virtual void personality()
        {
            Console.WriteLine("He has a bad personaltiy");
        }
        public Person() { }

    }
}
