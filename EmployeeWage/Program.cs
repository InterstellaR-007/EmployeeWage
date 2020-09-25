using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part time Employee wage is "+ PartTimeWage());
        }
        public static int PartTimeWage()
        {
            Random rnd = new Random();
            int wage_calculated = rnd.Next(0, 9) * 20;
            return wage_calculated;

        }
        
    }
}
