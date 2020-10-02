using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeWage
{
    class EmpWage_Builder
    {
        ArrayList company_list = new ArrayList();
        private String current_company;
        private int current_empRatePerHour;
        private int current_numOfWorkingDays = 0;
        private int current_maxNumberOfHours = 0;

        ////String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours
        public EmpWage_Builder()
        {

        }
        public void addCompanyDetails(CompanyEmpWage companyObject) {
            

            company_list.Add(companyObject);

        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage x in company_list)
            {
                int empHours = 0;
                int totalEmpHours = 0;
                int totalEmpWage = 0;
                int wageCalculated = 0;
                int totalDays = 0;

                while (totalEmpHours <= x.maxNumberOfHours && totalDays <= x.numOfWorkingDays)
                {
                    totalDays++;

                    Random rnd = new Random();
                    int empCheck = rnd.Next(0, 2);
                    switch (empCheck)
                    {
                        case 0:
                            empHours = 4;
                            break;
                        case 1:
                            empHours = 8;
                            break;
                        default:
                            empHours = 0;
                            break;
                    }
                    totalEmpHours = totalEmpHours + empHours;
                    wageCalculated = empHours * x.empRatePerHour;
                    totalEmpWage = totalEmpWage + wageCalculated;


                }
                Console.WriteLine(" Employee wage of Company " + x.company + " is: " + totalEmpWage);

            }
        }
    }
}
