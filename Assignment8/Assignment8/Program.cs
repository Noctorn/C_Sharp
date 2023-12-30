using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*8) Write a program to find LEAP year by using – 
                a.If – Else and logical operators.
                b.Conditional operator.
                c.Note – A Leap year is divisible by 4 and is not divisible by 100 but it could be divisible by 400*/
            try
            {
                Console.WriteLine("Enter a year");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("It is a leap year");

                }
                else
                {
                    Console.WriteLine("It is not a sleep year");
                }
                Console.ReadKey();

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
        }
    }
}
