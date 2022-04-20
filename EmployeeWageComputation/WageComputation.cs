using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int employeeWorkingHrs = 20;
        const int employeeWorkingDays = 20;
        public void EmpWage()
        {
            int salary = 0;
            int totalSalary = 0;
            int empHrs = 0;
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {


                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                salary = empHrs * employeeWorkingHrs;
                Console.WriteLine("Day" + i + " " + salary);
                totalSalary = totalSalary + salary;
                if (empHrs <= 100)
                {
                    sum = sum + empHrs;
                }
            }

            Console.WriteLine("Total Salary of 20days" + " =" + totalSalary);
            Console.WriteLine("Total Working Hrs is" + " " + sum);

        }
    }
}