using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int empCheck1 = random.Next(0, 3);
            int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;
            if (empCheck1 == IS_FULL_TIME)
            {
                empHr = 8;
                Console.WriteLine("Employe is present & doing full-time");
            }
            else if (empCheck1 == IS_PART_TIME)
            {
                empHr = 4;
                Console.WriteLine("Employe is present & doing part-time");
            }
            else
            {
                empHr = 0;
                Console.WriteLine("Employe is not present");
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
