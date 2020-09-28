using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            empwage_new emp1 = new empwage_new("abc", 20, 20, 100);
            emp1.EmpWage();
            empwage_new emp2 = new empwage_new("thg", 10, 20, 10);
            emp2.EmpWage();

        }


    }
}
