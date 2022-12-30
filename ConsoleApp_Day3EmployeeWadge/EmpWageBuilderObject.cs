using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day3EmployeeWadge
{
    public class EmpWageBuilderObject
    {
        private string company;
        private int EMP_RATE_PER_HOUR;
        private int NUM_OF_WORKING_DAYS;
        private int MAX_HRS_IN_MONTH;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH) // creating constructor
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WORKING_DAYS= NUM_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH= MAX_HRS_IN_MONTH;
        }
        public  void computeEmpWages()   //Creating method for wages

        {
            int totalEmpHr = 0, empHr = 0, totalEmpWadge = 0, totalWorkingDays = 0,empWage=0;
            while (totalEmpHr <= this.MAX_HRS_IN_MONTH && totalWorkingDays < this.NUM_OF_WORKING_DAYS)  // while loop for condition
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
                empWage = EMP_RATE_PER_HOUR * empHr;
                totalEmpHr = totalEmpHr + empHr;
                totalEmpWage = totalEmpHr * EMP_RATE_PER_HOUR;
                totalWorkingDays++;
            }
            totalEmpWadge = totalEmpHr * this.EMP_RATE_PER_HOUR; // calculating the total value of employee wadge
            Console.WriteLine("Total Employee wages for {0} {1} days:{2} and Hrs:{3}", company, (totalWorkingDays - 1), totalEmpWage, (totalEmpHr - empHr));

        }

      
    }
}
