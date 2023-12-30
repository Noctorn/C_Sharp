using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7) Write a program to calculate Net Salary of an employee using Basic Salary based on following parameters – 
 a.HRA is 20 % of basic salary.
 b.DA is 40 % of basic salary.
 c.PF is 10 % of Gross salary.
 d.Gross Salary is Basic Salary + HRA + DA.
 e.Net salary is Gross Salary – PF.*/
            try
            {
                Console.WriteLine("Enter the salary of employee: ");
                float sal = float.Parse(Console.ReadLine());
                float hra = sal * 0.2f;
                float da = sal * 0.4f;
                float gs = sal + hra + da;
                float pf = gs * 0.1f;
                float netSal = gs - pf;

                Console.WriteLine("The net salary of employee is: {0},the pf is {1}", netSal, pf);
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
