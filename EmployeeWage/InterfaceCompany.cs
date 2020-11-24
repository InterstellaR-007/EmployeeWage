using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    /// <summary>
    /// Interfrace for Employee Wage Calculation
    /// </summary>
    public interface InterfaceCompany
    {
        /// <summary>
        /// Adds the company details.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxNumberOfHours">The maximum number of hours.</param>
        public void addCompanyDetails(String company, int empRatePerHour, int numOfWorkingDays, int maxNumberOfHours);

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void computeEmpWage();

        /// <summary>
        /// Gets the emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        public void getEmpWage(String company);

    }
}
