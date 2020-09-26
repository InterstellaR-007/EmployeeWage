using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Employee wage is "+ EmpWage());
        }
        public static int EmpWage()
        {
            int empHours = 0;
            
            Random rnd = new Random();
            int empCheck = rnd.Next(0, 2) ;
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
            int wageCalculated = empHours * 20;
            
            return wageCalculated;

        }
        
    }
}
