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
            int EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;
            switch (empCheck1)
            {
                case 1:
                empHr = 8;
                Console.WriteLine("Employe is present & doing full-time");
                    break;
                case 2:
                empHr = 4;
                Console.WriteLine("Employe is present & doing part-time");
                    break;
                default:
                empHr = 0;
                Console.WriteLine("Employe is not present");
                    break;
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
