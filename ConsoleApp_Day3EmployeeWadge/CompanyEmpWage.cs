using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day3EmployeeWadge
{
    public class CompanyEmpWage
    {
        public string company;
        public int EMP_RATE_PER_HOUR;
        public int NUM_OF_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }

        public void SetTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public override string ToString()
        {
            return $"company:{company} RatePerHr:{EMP_RATE_PER_HOUR} Days:{NUM_OF_WORKING_DAYS} Hrs:{MAX_HRS_IN_MONTH}";
        }
    }
}
