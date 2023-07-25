using HomeWork25._07._23.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25._07._23.Controllers
{
    internal class DoctorController
    {
        public void GetDoctorByDate()
        {
            DoctorService doctorService = new DoctorService();

            DateTime firstDate = new DateTime(1993, 05, 25);
            DateTime secondDate = new DateTime(2002, 12, 15);

            doctorService.GetDoctorsByDate(firstDate, secondDate);
        }
    }
}
