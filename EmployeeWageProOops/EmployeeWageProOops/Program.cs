using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageOops EmployeeWage = new EmpWageOops();
            EmployeeWage.Attendance("DMart", 20, 2, 10);
            EmployeeWage.Attendance("BigBazar", 10, 4, 20);
            EmployeeWage.Attendance("BigBascket", 15, 6, 22);

            Console.ReadKey();

        }
    }
}