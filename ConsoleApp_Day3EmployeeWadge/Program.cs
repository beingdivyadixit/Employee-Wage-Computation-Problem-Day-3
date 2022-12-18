using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int empCheck1 = random.Next(0, 2);
            int IS_FULL_TIME = 1;
            if (empCheck1 == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
        }
    }
}
