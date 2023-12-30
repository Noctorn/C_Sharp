using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10) Using a switch case write a menu driven program to
             * perform basic calculations of two user entered numbers.
                */
            int nums = 0;
            do
            {
                Console.WriteLine("This is a menu driven program");
                Console.WriteLine("Enter 1 to add, 2 to sub, 3 to multiply, 4 to divide");
                int num = int.Parse(Console.ReadLine());
                nums = num;
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("The sum of two numbers is: {0}", a + b);
                        break;

                    case 2:
                        Console.WriteLine("The sub of two numbers is: {0}", a - b);
                        break;
                    case 3:
                        Console.WriteLine("The mul of two numbers is: {0}", a * b);
                        break;
                    case 4:
                        Console.WriteLine("The div of two numbers is: {0}", a / b);
                        break;
                    default:
                        Console.WriteLine("enter a valid number");
                        break;
                }
            } while (nums!=0);

        }
    }
}
