using HomeWork25._07._23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork25._07._23.Services
{
    internal class EmployeeServices
    {
        public void GetBySalary(int salary)
        {
            var employees = GetEmployees();

            foreach (var item in employees)
            {
                if ( item.Salary > 1000 && item.Salary < 2000)
                {
                    Console.WriteLine(item.Name);
                    
                }
            }
        }

        private Employee[] GetEmployees()
        {
            Employee employee1 = new()
            {
                Id = 1,
                Name = "Sharaf",
                Surname = "Tanzinli",
                Age = 26,
                Salary = 1700
            };

            Employee employee2 = new()
            {
                Id = 2,
                Name = "Cahangir ",
                Surname = "Axundov",
                Age = 20,
                Salary = 1200
            };

            Employee employee3 = new()
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Mirzayev",
                Age = 30,
                Salary = 800
            };

            Employee[] employees = { employee1, employee2, employee3 };

            return employees;
        }
    }
}
