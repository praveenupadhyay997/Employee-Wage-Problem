using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class CompanyEmployeeWage
    {
        public string company;
        public int ratePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public int dailyEmpWage;

        public CompanyEmployeeWage(string company, int ratePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.ratePerHours = ratePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            totalEmpWage = 0;
        }

        public void SettotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public void SetDailyEmpWage(int dailyEmpWage)
        {
            this.dailyEmpWage = dailyEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + company + " is " + totalEmpWage;
        }
        
        public string toDailyString()
        {
            return "Daily Emp Wage for company : " + company + " is " + dailyEmpWage;
        }
    }
}
