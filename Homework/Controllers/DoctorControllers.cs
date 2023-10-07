using System;
using Homework.Models;
using Homework.Services;

namespace Homework.Controllers;

public class DoctorsControllers
{
    public void GetByBirthday()
    {
        DoctorServices doctorService = new();

        Doctors[] doctors = doctorService.GetByBirthday(new(1995, 05, 25), new(2003, 12, 15)).ToArray();

        foreach (var doctor in doctors)
        {
            Console.WriteLine(doctor.Name + " " + doctor.Surname);
        }
    }
}

