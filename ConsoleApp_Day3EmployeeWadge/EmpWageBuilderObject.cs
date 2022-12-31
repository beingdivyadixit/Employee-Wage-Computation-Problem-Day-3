using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day3EmployeeWadge
{
    class EmpWageBuilderObject
    {
        List<CompanyEmpWage> list; //using collection
        Dictionary<string, CompanyEmpWage> dic; //Using Dictionary

        //using array
       // CompanyEmpWage[] companies;
       // int numbOfCompanies = 0;   

        public EmpWageBuilderObject() // creating constructor
        {

            // companies = new CompanyEmpWage[5];
            list = new List<CompanyEmpWage>();
            dic = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddComapnyDetailsIntoArray(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            CompanyEmpWage comp = new CompanyEmpWage(company, EMP_RATE_PER_HOUR, NUM_OF_WORKING_DAYS, MAX_HRS_IN_MONTH);
            // companies[numbOfCompanies] = comp;
            //numbOfCompanies++;
            list.Add(comp);
            dic.Add(company, comp);
        }
        public int GetTotalWageBasedOnCompany(string companyName)
        {
            return dic[companyName].totalEmpWage;
        }

        public void IterateOverCompany()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int totalEmpWage = computeEmpWages(list[i]);
                list[i].SetTotalWage(totalEmpWage);
                Console.WriteLine(list[i].ToString());
            }
        }
        public  int computeEmpWages(CompanyEmpWage companyDetails)   //Creating method for wages

        {
            int totalEmpHr = 0, empHr = 0, totalEmpWage = 0, totalWorkingDays = 0,empWage=0;
            while (totalEmpHr <= companyDetails.MAX_HRS_IN_MONTH && totalWorkingDays < companyDetails.NUM_OF_WORKING_DAYS)  // while loop for condition
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
                empWage =companyDetails.EMP_RATE_PER_HOUR * empHr;
                totalEmpHr = totalEmpHr + empHr;
                totalEmpWage = totalEmpHr *companyDetails.EMP_RATE_PER_HOUR;
                totalWorkingDays++;
            }
            totalEmpWage = totalEmpHr * companyDetails.EMP_RATE_PER_HOUR; // calculating the total value of employee wadge
            //Console.WriteLine("Total Employee wages for {0} {1} days:{2} and Hrs:{3}", company, (totalWorkingDays - 1), totalEmpWage, (totalEmpHr - empHr));
            return totalEmpWage;
        }

      
    }
}
