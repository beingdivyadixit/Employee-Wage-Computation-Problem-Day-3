using System;

namespace ConsoleApp_Day3EmployeeWadge
{
    internal class Program
    {
      
        static void Main(string[] args)
        {   //Calling methods in main method by creating obj of constructor
            EmpWageBuilderObject BridgeLabz = new EmpWageBuilderObject("BridgeLabz", 20,22,10);
            BridgeLabz.computeEmpWages();
            EmpWageBuilderObject Wipro = new EmpWageBuilderObject("Wipro", 20, 25, 10);
            Wipro.computeEmpWages();
            EmpWageBuilderObject Hcl = new EmpWageBuilderObject("Hcl", 20, 28, 10);
            Hcl.computeEmpWages();
        }
      

    }
    
}
