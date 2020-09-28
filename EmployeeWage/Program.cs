using System;

namespace EmployeeWage
{
    class Program
    {

        
        static void Main(string[] args)
        {
            empwage_new emp1 = new empwage_new();
            emp1.addCompanyDetails("thg", 10, 20, 10);
            emp1.addCompanyDetails("abc", 50, 10, 50);
            emp1.addCompanyDetails("afff", 40, 100, 20);
            emp1.addCompanyDetails("asdv", 10, 100, 80);
            emp1.addCompanyDetails("jgh", 40, 50, 40);
            emp1.computeEmpWage();

        }
        
        
    }
}

