using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        //constance value
        const int PART_TIME_EMP = 1,
        FULL_TIME_EMP = 2,
        EMP_FULL_DAY_WRKING_HR = 8,
        EMP_PART_TIME_WRKING_HR = 4;

        //variable values
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;

        public void EmpWage(string company_Name, int EMP_WAGE_PR_HR, int MAX_WORKING_HR, int EMP_WORKING_Days_PR_MONTH)
        {
            while (day <= EMP_WORKING_Days_PR_MONTH && empHrs <= MAX_WORKING_HR)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME_EMP:

                        empHrs += EMP_FULL_DAY_WRKING_HR;
                        break;
                    case PART_TIME_EMP:

                        empHrs += EMP_PART_TIME_WRKING_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
            }
            totalEmpSalary = empHrs * EMP_WAGE_PR_HR;
            Console.WriteLine("Company : " + company_Name + ", Emp Working Hour : " + EMP_WAGE_PR_HR + ", Maximum working Hour : " + MAX_WORKING_HR + ", Total Days In Month : " + EMP_WORKING_Days_PR_MONTH);
            Console.WriteLine("One month Employee Salary is :" + totalEmpSalary);
        }
    }
}