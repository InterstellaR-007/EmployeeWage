using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeWage
{
    class empwage_new
    {
        ArrayList company_list = new ArrayList();
        Dictionary<String,int> TotalWagesList = new Dictionary<string, int>();
        private String current_company;
        private int current_empRatePerHour;
        private int current_numOfWorkingDays = 0;
        private int current_maxNumberOfHours = 0;

        ////String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours
        public empwage_new()
        {

        }
        public void addCompanyDetails(String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours) {
            empwage_new emp = new empwage_new();
            emp.current_company = company;
            emp.current_empRatePerHour = empRatePerHour;
            emp.current_maxNumberOfHours = maxNumberOfHours;
            emp.current_numOfWorkingDays = current_numOfWorkingDays;
            company_list.Add(emp);

        }

        public void getEmpWage()
        {
            foreach(KeyValuePair<String,int> i in TotalWagesList)
            {
                Console.WriteLine(" Employee wage of Company " + i.Key+ " is: " + i.Value);
            }
        }
        public void computeEmpWage()
        {
            foreach (empwage_new x in company_list)
            {
                int empHours = 0;
                int totalEmpHours = 0;
                int totalEmpWage = 0;
                int wageCalculated = 0;
                int totalDays = 0;

                while (totalEmpHours <= x.current_maxNumberOfHours && totalDays <= x.current_numOfWorkingDays)
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
                    wageCalculated = empHours * x.current_empRatePerHour;
                    totalEmpWage = totalEmpWage + wageCalculated;


                }
                TotalWagesList.Add(x.current_company,totalEmpWage);
                

            }
        }
    }
}
