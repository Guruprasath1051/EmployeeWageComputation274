using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0; int empWage = 0;

            Console.WriteLine("Welcome To EmployeeWage Computation");
            //UC1 - EmployeeAttendence
            Random random= new Random();
            int empAttendence = random.Next(0, 3);//0 or 1 or 2
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empAttendence== PART_TIME)
            {
                Console.WriteLine("Part Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage:{0}", empWage);
            Console.ReadLine();
        }
    }
}
