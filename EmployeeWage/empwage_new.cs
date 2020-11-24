using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeWage
{
    class empwage_new
    {

        /// <summary>
        /// The company list
        /// </summary>
        ArrayList company_list = new ArrayList();
        /// <summary>
        /// The total wages count of Employees Company Wise
        /// </summary>
        Dictionary<String,int> TotalWagesList = new Dictionary<string, int>();

        private String current_company;
        private int current_empRatePerHour;
        private int current_numOfWorkingDays = 0;
        private int current_maxNumberOfHours = 0;

        

        /// <summary>
        /// Adds the company details.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxNumberOfHours">The maximum number of hours.</param>
        public void addCompanyDetails(String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours) {

            CompanyDetail companyDetail = new CompanyDetail();
            companyDetail.company = company;
            companyDetail.empRatePerHour = empRatePerHour;
            companyDetail.numOfWorkingDays = numOfWorkingDays;
            companyDetail.maxNumberOfHours = maxNumberOfHours;
            company_list.Add(companyDetail);

        }

        /// <summary>
        /// Gets the emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        public void getEmpWage(String company)
        {
            foreach(KeyValuePair<String,int> i in TotalWagesList)
            {
                if(company.CompareTo(i.Key)==0)
                Console.WriteLine(" Employee wage of Company " + i.Key+ " is: " + i.Value);
            }
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void computeEmpWage()
        {
            foreach (CompanyDetail x in company_list)
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
                TotalWagesList.Add(x.company,totalEmpWage);
                

            }
        }
    }
}
