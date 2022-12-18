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
            int IS_FULL_TIME = 1, EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;
            if (empCheck1 == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
