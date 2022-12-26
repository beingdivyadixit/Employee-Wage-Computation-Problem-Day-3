using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
       public const int EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20, MAX_HRS_IN_MONTH = 100;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");
            calculateWages();
        }
         
        
          public static void calculateWages()

          {     
                int totalEmpHr = 0, empHr = 0, totalEmpWadge = 0, totalWorkingDays = 0;
                while (totalEmpHr <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                    totalEmpHr = totalEmpHr + empHr;
                    totalWorkingDays++;
                }
                totalEmpWadge = totalEmpHr * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Employee Wadge For A Month:" + totalEmpWadge);
          }
        

    }
    
}
