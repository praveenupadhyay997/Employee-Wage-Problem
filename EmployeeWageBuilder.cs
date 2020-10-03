using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeWageBuilder : IComputeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyEmployeeWage> companyEmpWagesList;



        public EmployeeWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmployeeWage>();

        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmployeeWage companyEmpWage = new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWagesList.AddLast(companyEmpWage);

        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmployeeWage companyEmpWage in this.companyEmpWagesList)
            {
                int totalEmpWageTemp = this.ComputeEmpWage(companyEmpWage);
                companyEmpWage.SettotalEmpWage(totalEmpWageTemp);
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        public int ComputeEmpWage(CompanyEmployeeWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            while (totalEmpHours < companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
            {
                EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
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

        public void ComputeDailyWage()
        {
            foreach (CompanyEmployeeWage companyEmpWage in this.companyEmpWagesList)
            {
                int dailyEmpWageTemp = this.ComputeDailyWage(companyEmpWage);
                companyEmpWage.SetDailyEmpWage(dailyEmpWageTemp);
                Console.WriteLine("\n"+companyEmpWage.toDailyString());
            }
        }

        public int ComputeDailyWage(CompanyEmployeeWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours = 0;
            int totalWagePerDay = 0;

                EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
                empHours = empWageBuilder.GetWorkingHours();

            if (empHours != 0)
            {
                workingDays++;
                totalWagePerDay = empHours * companyEmpWage.ratePerHours;
                //Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
            }
          
            return totalWagePerDay;

        }


    }
}