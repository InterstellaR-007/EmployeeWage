using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public interface InterfaceCompany
    {
        public void addCompanyDetails(String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours);

        public void computeEmpWage();

        public void getEmpWage(String company);



    }
}
