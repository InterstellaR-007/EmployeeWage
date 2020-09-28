using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            int wageCalculated = 0;
            int totalDays = 0;

            while (totalEmpHours <= 100 || totalDays <= 20)
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
                wageCalculated = empHours * 20;
                totalEmpWage = totalEmpWage + wageCalculated;


            }
           
            Console.WriteLine(" Employee wage is "+ totalEmpWage);
        }
        
        
    }
}
