using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
      
        static void Main(string[] args)
        {  
            EmpWageBuilderObject builder = new EmpWageBuilderObject();
            builder.AddComapnyDetailsIntoArray("BridgeLabz", 20, 22, 10);
            builder.AddComapnyDetailsIntoArray("Wipro", 20, 25, 10);
            builder.AddComapnyDetailsIntoArray("Hcl", 20, 28, 10);
            builder.IterateOverCompany();
            Console.WriteLine("Get total wages using companyName " + builder.GetTotalWageBasedOnCompany("BridgeLabz"));
        }
      

    }
    
}
