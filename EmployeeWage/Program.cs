using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
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
