using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          Person person = new Person();
          Student student=new Student();
            student.Name = "Deepak";
            student.Age = 20;
            student.Birthday= DateTime.Now;
            student.Gender = "Male";
            student.Id = 1;
            Console.ReadKey ();
        }
    }
}
//