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
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("ZS Associate", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("BridgeLabz", 40, 40, 70);
            empWageBuilder.computeEmpWage();
        }
    }
}
