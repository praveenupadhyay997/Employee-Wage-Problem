using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilder : IComputeWage, IComputeWageForQuery
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        /// <summary>
        /// The company emp wages list anf the dictionary mapped with key as company name
        /// </summary>
        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpWageBuilder"/> class.
        /// </summary>
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        /// <summary>
        /// Adds the company emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                int totalEmpWageTemp = this.ComputeEmpWage(companyEmpWage);
                companyEmpWage.SettotalEmpWage(totalEmpWageTemp);
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <param name="companyEmpWage">The company emp wage.</param>
        /// <returns></returns>
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            while (totalEmpHours < companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empHours = empWageBuilder.GetWorkingHours();

                if (totalEmpHours == 96)
                {
                    empHours = 4;
                }
                if (empHours != 0)
                {
                    workingDays++;
                    totalEmpHours = empHours + totalEmpHours;
                    totalWagePerDay = empHours * companyEmpWage.ratePerHours;
                    totalWagePerMonth += totalWagePerDay;
                    Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
                }
            }
            return totalWagePerMonth;

        }

        /// <summary>
        /// Gets the working hours.
        /// </summary>
        /// <returns></returns>
        public int GetWorkingHours()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHours = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case FULL_TIME:
                    empHours = 8;
                    break;
                case PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            return empHours;
        }
        /// <summary>
        /// Gets the total wage.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns></returns>
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
