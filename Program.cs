using System;

namespace EmployeeWageProblem
{
    class Program
    {
        //Constant for Part time and Full time
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        //Computational Function
        public static float wageCalculation(string companyName, int employeeRatePerHour, int workingDays, int maxHours)
        {
            int empHour = 0, totalEmpHour = 0, totalWorkDay = 0;

            while (totalEmpHour < maxHours && totalWorkDay < workingDays)
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

            int totalEmployeeWage = totalEmpHour * employeeRatePerHour;
            Console.WriteLine("Total Wage of an Employee for company = {0} is {1}", companyName, totalEmployeeWage);
            return totalEmployeeWage;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
            wageCalculation("ZSAssociate", 20, 10, 100);
            wageCalculation("IHS Markit", 100, 50, 200);
        }
    }
}
