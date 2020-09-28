using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeWage
{
    class empwage_new
    {

        private String current_company;
        private int current_empRatePerHour;
        private int current_numOfWorkingDays = 0;
        private int current_maxNumberOfHours = 0;


        public empwage_new(String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours)
        {
            current_company = company;
            current_empRatePerHour = empRatePerHour;
            current_numOfWorkingDays = numOfWorkingDays;
            current_maxNumberOfHours = maxNumberOfHours;
        }
        public void EmpWage()
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            int wageCalculated = 0;
            int totalDays = 0;

            while (totalEmpHours <= current_maxNumberOfHours && totalDays <= current_numOfWorkingDays)
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
                wageCalculated = empHours * current_empRatePerHour;
                totalEmpWage = totalEmpWage + wageCalculated;


            }
            Console.WriteLine(" Employee wage of Company " + current_company + " is: " + totalEmpWage);

        }
    }
}
