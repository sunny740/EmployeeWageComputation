using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_PRESENT = 0;
        //public void Employee()
        //{
        //    Random random = new Random();
        //    int check = random.Next(0, 2);
        //    if (check == IS_PRESENT)
        //        Console.WriteLine("Employee is present");
        //    else
        //        Console.WriteLine("Employee is Not Present");
        //}

        //Conatant 
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        //Variable
        public void CalculteEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}