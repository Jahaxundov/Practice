using ClassWork24._07._23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24._07._23.Servisces
{
    internal class EmployeeService
    {
        public int GetAverageAge()
        {
            Employee[] employees = GetEmployees();

            int sumAge = 0;
            int employeeCount = employees.Length;
            foreach (var employee in employees)
            {
                sumAge += employee.Age;
            }
            int result = sumAge / employeeCount;
            return result;  
        }

        public void SearchByPosition(string position)
        {
            var employees = GetEmployees();
            foreach (var item in employees)
            {
                if (item.Position.Trim().ToLower().Contains(position.ToLower().Trim()))
                {
                    Console.WriteLine($"{item.FullName} ,{item.Age}, {item.Position}");
                }
            }
        }
        private Employee[] GetEmployees()
        {
            Employee employee1 = new()
            {
                Id=1,
                FullName="Sharaf Tanzinli",
                Age=26,
                Position="Developer"
            };

            Employee employee2 = new()
            {
                Id = 2,
                FullName = "Cahangir Axundov",
                Age = 20,
                Position = "Jumper"
            };

            Employee employee3 = new()
            {
                Id = 2,
                FullName = "Pervin Mirzayev",
                Age = 30,
                Position = "Developer"
            };

            Employee[] employees = { employee1, employee2, employee3 };

            return employees;

        }
    }
}
