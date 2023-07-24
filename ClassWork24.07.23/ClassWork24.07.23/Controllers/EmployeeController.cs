using ClassWork24._07._23.Servisces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24._07._23.Controllers
{
    internal class EmployeeController
    {
        private EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }
        public void GetAverageAge()
        {
            int averageAge = _employeeService.GetAverageAge();
            Console.WriteLine(averageAge);
        }

        public void SearchByPosition()
        {
            Console.WriteLine("Add search text :");
            string position = Console.ReadLine();
            _employeeService.SearchByPosition(position);
        }
    }
}
