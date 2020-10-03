using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int EMP_RATE_PERHOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOUR_IN_MONTH = 100;

        public static float wageCalculation()
        {
            int empHour = 0, totalEmpHour = 0, totalWorkDay = 0;

            while (totalEmpHour < MAX_HOUR_IN_MONTH && totalWorkDay < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empAttendance = random.Next(0, 3);
                if (empAttendance != 0)
                {
                    totalWorkDay++;
                }

                switch (empAttendance)
                {
                    case PART_TIME:
                        empHour = 4;
                        break;
                    case FULL_TIME:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }

                totalEmpHour += empHour;
                Console.WriteLine("Number of Days = {0}, Employee Hours ={1}", totalWorkDay, totalEmpHour);
            }

            int totalEmployeeWage = totalEmpHour * EMP_RATE_PERHOUR;
            Console.WriteLine("Total Wage of an Employee = {0}", totalEmployeeWage);
            return totalEmployeeWage;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
            wageCalculation();
        }
    }
}
