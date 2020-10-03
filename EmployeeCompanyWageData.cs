using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeCompanyWageData
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private string companyName;
        private int employeeWagePerHour;
        private int workingDays;
        private int maxHrPerMonth;
        public int totalWage;

        public EmployeeCompanyWageData(string company, int empRaterPerHour, int numOfWorkDay, int maxHourPerMonth)
        {
            this.companyName = company;
            this.employeeWagePerHour = empRaterPerHour;
            this.workingDays = numOfWorkDay;
            this.maxHrPerMonth = maxHourPerMonth;
            this.totalWage = 0;
        }
        public void calculateWage()
        {
            int empHour = 0, totalEmpHour = 0, totalWorkDay = 0;

            while (totalEmpHour < this.maxHrPerMonth && totalWorkDay < this.workingDays)
            {
                Random ran = new Random();
                int empAttendance = ran.Next(0, 3);
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

            int totalWage = totalEmpHour * this.employeeWagePerHour;
            //Console.WriteLine("Total Wage of an Employee : {0} for Company :{1}", totalWage, this.companyName);
            this.totalWage = totalWage;
        }

        public string toString()
        {
            return "Total Emp Wage For Company : " + this.companyName + " is: " + this.totalWage;
        }
    }
}