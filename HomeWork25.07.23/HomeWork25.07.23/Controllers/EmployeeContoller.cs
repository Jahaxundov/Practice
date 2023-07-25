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
            int firstSalary = 1000;
            int secondSalary = 2000;
           
            employeeService.GetBySalary(firstSalary,secondSalary);
        }
    }
}
