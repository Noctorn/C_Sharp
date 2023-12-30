using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  9) Write a program to accept the basic salary and total sales amount 
             *  from a salesperson and calculate commission according 
             *  to the sales amount.Display the net salary and commission earned.
              Sales Amount in Rs.
              Commission(%) on Sales
                  5,000 to 7,500  3
                  7,501 to 10,500 8
                  10,501 to 15,000 11
                  15,000 to above 15*/
            try
            {
                Console.WriteLine("Enter the salary of employee");
                float salary = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the total sales amount: ");
                float salesAmount = float.Parse(Console.ReadLine());
                if (salary >= 5000 && salary <= 7500)
                {
                    salesAmount *= 0.03f;
                    salary += salesAmount;
                    Console.WriteLine("Your salary is {0}", salary);
                }
                else if (salary >= 7501 && salary <= 10500)
                {
                    salesAmount *= 0.08f;
                    salary += salesAmount;
                    Console.WriteLine("Your salary is {0}", salary);

                }
                else if (salary >= 10501 && salary <= 15000)
                {
                    salesAmount *= 0.11f;
                    salary += salesAmount;
                    Console.WriteLine("Your salary is {0}", salary);
                }
                else if (salary >= 15001)
                {
                    salesAmount *= 0.15f;
                    salary += salesAmount;
                    Console.WriteLine("Your salary is {0}", salary);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}
