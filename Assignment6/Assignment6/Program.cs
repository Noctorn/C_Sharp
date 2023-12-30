using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6) Accept a character from a user and print its ASCII value using Console Application.*/
            try
            {
                Console.WriteLine("Enter a character");
                char ch = char.Parse(Console.ReadLine());
                int ascii = (int)ch;
                Console.WriteLine($"The value of the charater {ascii}");
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
