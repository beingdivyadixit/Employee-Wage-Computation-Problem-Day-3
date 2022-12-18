using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20;
            int empWadge = 0, empHr = 0, totalEmpWadge = 0;
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck1 = random.Next(0, 3);
                switch (empCheck1)
                {
                    case 1:
                        empHr = 8;
                        break;
                    case 2:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                empWadge = empHr * EMP_RATE_PER_HOUR;
                totalEmpWadge = totalEmpWadge + empWadge;
            }
            Console.WriteLine("Total Employee Wadge For A Month:" + totalEmpWadge);
        }
    }
}
