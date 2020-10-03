using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
            // Declaring Objects for different companies
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            //Adding the Company Data
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 14, 130);
            //Compute the total Wage
            empWageBuilder.ComputeEmpWage();
            Console.ReadKey();
        }
    }

    //Interface with functionality to add the details in both list and dictionary and store the total employee wage
    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        void ComputeEmpWage();
    }

    //Interface with functionality to search the total employee wage by the company name mapped on Dictionary
    public interface IComputeWageForQuery
    {
        int GetTotalWage(string company);
    }
}

