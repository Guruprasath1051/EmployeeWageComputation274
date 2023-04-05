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
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 50;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0, day = 1,totalWage = 0,totalHrs =0;

            Console.WriteLine("Welcome To EmployeeWage Computation");
            //UC1 - EmployeeAttendence
            Random random= new Random();
            while (day <=MAX_WORKING_DAYS && totalHrs<= MAX_WORKING_HRS) 
            {
                int empAttendence = random.Next(0, 3);//0 or 1 or 2
                switch (empAttendence)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Part Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day{0} Employee Wage:{1} TotalHrs:{2}", day, empWage,totalHrs);
                //totalWage = totalWage + empWage;
                totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("Total Employee Wage for {0} days:{1} and TotalHrs:{2}", (day - 1), totalWage,totalHrs);
            Console.ReadLine();
        }
    }
}
