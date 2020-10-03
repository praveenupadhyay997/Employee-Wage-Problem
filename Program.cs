using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
            // Declaring Objects for companies
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 2, 20);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 14, 40);
            //Calling the method to compute total wage and storing it in the class member
            empWageBuilder.ComputeEmpWage();
            //Calling the method to compute daily wage and storing it in the class member
            empWageBuilder.ComputeDailyWage();
            Console.ReadKey();
        }
    }

    //Interface Upholding the three operations namely add, compute daily wage and compute total wage
    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeDailyWage();
        void ComputeEmpWage();
    }
}

