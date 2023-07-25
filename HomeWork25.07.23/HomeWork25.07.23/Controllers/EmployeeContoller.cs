using HomeWork25._07._23.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25._07._23.Controllers
{
    internal class EmployeeContoller
    {
        public void SearchBySalary()
        {
            EmployeeServices employeeService = new();
            Console.WriteLine("Salary daxil et");
            int salary = Convert.ToInt32(Console.ReadLine());
            employeeService.GetBySalary(salary);
        }
    }
}
