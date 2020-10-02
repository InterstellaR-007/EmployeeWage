using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class CompanyEmpWage

    {
        public String company;
        public int empRatePerHour;
        public int numOfWorkingDays = 0;
        public int maxNumberOfHours = 0;

        public CompanyEmpWage(String company, int empRatePerHour,int numOfWorkingDays,int maxNumberOfHours)

        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxNumberOfHours = maxNumberOfHours;
        }

        
    }
    
}
