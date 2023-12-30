using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 2;
                Console.WriteLine("Enter a number: ");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine("Hello world");
                Console.WriteLine($"the value of i is {i}");
                Console.WriteLine($"The value entered by user is {j}");
                Console.WriteLine($"the sum of two values is {i+j}");
                if ((i+j)%2==0)
                {
                    Console.WriteLine($"the sum is even {i+j}"); 
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

                Console.Write("Enter a number to print its table: ");
                int num = int.Parse(Console.ReadLine());
                for (int k = 1; k <=10; k++)
                {
                    Console.WriteLine($"{num} * {k} = {num*k}");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
 