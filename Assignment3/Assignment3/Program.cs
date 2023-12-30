using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int sum = 0;
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine("Enter a number");
					int a = int.Parse(Console.ReadLine());
					sum += a;
				}
                Console.WriteLine($"The sum of five numbers is: {sum}");
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
