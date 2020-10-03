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
            EmployeeCompanyWageData ZSAssociate = new EmployeeCompanyWageData("ZSAssociate", 20, 20, 50);
            EmployeeCompanyWageData IHSMarkit = new EmployeeCompanyWageData("IHS Markit", 10, 40, 400);
            // Calling the Objects
            ZSAssociate.calculateWage();
            Console.WriteLine(ZSAssociate.toString());
            IHSMarkit.calculateWage();
            Console.WriteLine(IHSMarkit.toString());
        }
    }
}
