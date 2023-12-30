using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) Write a program to swap two variables using a third variable by Console Application.*/
            try
            {
                int a = 10, b = 20;
                Console.WriteLine($"Values before the swap a:{a} b:{b}");
                int c = b;
                b = a;
                a = c;
                Console.WriteLine($"Values after the swap a:{a} b:{b}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
