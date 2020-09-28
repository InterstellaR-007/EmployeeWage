using System;

namespace EmployeeWage
{
    class Program
    {

        public static String Attendance()
        {

            Random rnd = new Random();
            if (rnd.Next(0, 2) == 1)
            {
                return "Present";
            }
            else
            {
                return "Absent";
            }
        }
        static void Main(string[] args)
        {



            String st = Attendance();
            Console.WriteLine(st);


            Console.WriteLine("Welcome to Employee Wage Computation Program");



            int wage = DailyWage();
            Console.WriteLine("Calculated age is " + wage);
            Console.WriteLine(" Employee wage is " + EmpWage());
        }

        public static int DailyWage()
        {
            int FULL_DAY_HOURS = 8;
            Random rnd = new Random();
            int wage_calculated = rnd.Next(0, 9) * 20;
            return wage_calculated;

        }






        public static int EmpWage()
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
            return totalEmpWage;
        }


    }
}

