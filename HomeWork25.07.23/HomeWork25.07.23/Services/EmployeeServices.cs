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
        public void GetBySalary(int firstSalary,int secondSalary)
        {
            var employees = GetEmployees();

            foreach (var item in employees)
            {
                if ( item.Salary > firstSalary && item.Salary < secondSalary)
                {
                    Console.WriteLine(item.Name +","+ item.Surname+ "," + item.Age);
                    
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
                Salary = 2700
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
