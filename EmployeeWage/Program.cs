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
        }
    }
}
