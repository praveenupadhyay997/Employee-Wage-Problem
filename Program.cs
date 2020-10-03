using System;

namespace EmployeeWageProblem
{
    class Program
    {
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
            Display();
            EmployeeAttendance();
        }
    }
}