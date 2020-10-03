using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class CompanyEmpWage
    {
        public string company;
        public int ratePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="ratePerHours">The rate per hours.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        public CompanyEmpWage(string company, int ratePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.ratePerHours = ratePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        /// <summary>
        /// Settotals the emp wage.
        /// </summary>
        /// <param name="totalEmpWage">The total emp wage.</param>
        public void SettotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        /// <summary>
        /// To the string.
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + this.totalEmpWage;
        }
    }

}
