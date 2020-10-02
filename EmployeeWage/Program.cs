using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage_Builder emp_builder = new EmpWage_Builder();
            CompanyEmpWage c1 = new CompanyEmpWage("thg", 10, 20, 10);
            CompanyEmpWage c2 = new CompanyEmpWage("jgh", 40, 50, 40);
            CompanyEmpWage c3 = new CompanyEmpWage("asdv", 10, 100, 80);

            emp_builder.addCompanyDetails(c1);
            emp_builder.addCompanyDetails(c2);
            emp_builder.addCompanyDetails(c3);
            
            emp_builder.computeEmpWage();

        }
        
        
    }
}
