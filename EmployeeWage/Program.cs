using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage("abc",20,20,100);
            EmpWage("efg", 20, 30, 120);
        }
        public static void EmpWage(String company,int empRatePerHour, int numOfWorkingDays,int maxNumberOfHours)
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            int wageCalculated = 0;
            int totalDays = 0;

            while(totalEmpHours <=maxNumberOfHours && totalDays <=numOfWorkingDays)
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
                wageCalculated = empHours * empRatePerHour;
                totalEmpWage = totalEmpWage + wageCalculated;
                

            }
            Console.WriteLine(" Employee wage of Company "+ company +" is: "+ totalEmpWage);
            
        }
        
    }
}
