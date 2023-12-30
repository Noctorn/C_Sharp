using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int avg= 0;
				for (int i = 0; i < 5; i++)
				{
                    Console.WriteLine("Enter a number");
                    int a = int.Parse(Console.ReadLine());
					avg+= a;

				}
                Console.WriteLine($"the average of the all the numbers is {avg/5}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                throw;
			}
            Console.ReadKey();
        }
    }
}
