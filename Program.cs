using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public static float EmployeeDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            Random random = new Random();
            // A random object variable used to assign the time contribution of an employee
            int fullTime = random.Next(0, 2);
            if (fullTime == 1)
            {
                return wagePerHour * fullDayHour;
            }
            else
            {
                return 0;
            }
        }
        public static void Display()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
        }
        public static int EmployeeAttendance()
        {
            // Assigning a Random variable of 2 value range to check if the employee is present or absent
            Random random = new Random();
            int flag = random.Next(0, 2);
            if (flag == 1)
            {
                Console.WriteLine("The Employee is Present");
                return flag;
            }
            else
            {
                Console.WriteLine("The Employee is Absent");
                return flag;
            }
        }
        static void Main(string[] args)
        {
            // Calling the static Function Display
            Display();
            // Calling the static Function Employee Attendance
            EmployeeAttendance();
            // Calling the static function to Compute the daily wage for a full time employee
            Console.WriteLine(EmployeeDailyWage());
        }
    }
}