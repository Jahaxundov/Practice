using HomeWork25._07._23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25._07._23.Services
{
    internal class DoctorService
    {

        public void GetDoctorsByDate(DateTime firstDate,DateTime secondDate)
        {
            var doctors = GetDoctors();
            foreach (var item in doctors)
            {
                if(item.Birthday>firstDate && item.Birthday < secondDate)
                {
                    Console.WriteLine(item.Name+ ","+item.Surname+ ","+item.Birthday);
                }
            }
        }
        private Doctor[] GetDoctors()
        {
            Doctor doctor1 = new()
            {
                Id = 1,
                Name = "Sharaf",
                Surname = "Tanzinli",
                Adress = "Nerimanov",
                Birthday= new DateTime(1992,09,12)
            };

             Doctor doctor2 = new()
            {
                Id = 2,
                Name = "Cahangir ",
                Surname = "Axundov",
                Adress = "Xetai",
                Birthday = new DateTime(2002,10,10)
            };

            Doctor doctor3 = new()
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Mirzayev",
                Adress = "Suraxani",
                Birthday = new DateTime(2005,02,01)
            };

            Doctor[] doctors = { doctor1, doctor2, doctor3 };

            return doctors;
        }
    }
}
