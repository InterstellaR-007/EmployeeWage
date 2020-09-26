using System;

namespace EmployeeWage
{
    class Program
    {
        
        public static String Attendance()
        {
            
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 1){
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
            Console.WriteLine("Calculated age is "+ wage);
        }

        public static int DailyWage()
        {
            int FULL_DAY_HOURS = 8;
            Random rnd = new Random();
            int wage_calculated = rnd.Next(0, 9) * 20;
            return wage_calculated;

        }
       
        

    }
}
