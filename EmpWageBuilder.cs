using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilder
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[10];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int empHrs = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            while (totalEmpHrs < companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                Random ran = new Random();
                int empAttendance = ran.Next(0, 3);

                switch (empAttendance)
                {
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                if (totalEmpHrs == 96)
                {
                    empHrs = 4;
                }
                if (empHrs != 0)
                {
                    totalWorkingDays++;
                    totalEmpHrs = empHrs + totalEmpHrs;
                    totalWagePerDay = empHrs * companyEmpWage.empRatePerHour;
                    totalWagePerMonth += totalWagePerDay;
                    Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
                }
            }
            return totalWagePerMonth;
        }
    }
}
