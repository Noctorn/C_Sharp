using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int a = 10, b = 20;
                Console.WriteLine($"The sum of two numbers is : {a+b}");
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
