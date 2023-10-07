using System;
using Homework.Models;
namespace Homework.Services;

public class DoctorServices
{
    private Doctors[] GetAll()
    {
        Doctors doctor1 = new()
        {

            Id = 1,
            Name = "Nisa",
            Surname = "Narimanova",
            Address = "Yasamal",
            Birthday = new(1997, 12, 31),
        };

        Doctors doctor2 = new()
        {
            Id = 2,
            Name = "Rafig",
            Surname = "Mammadli",
            Address = "Yasamal",
            Birthday = new(1997, 04, 11)
        };

        Doctors doctor3 = new()
        {
            Id = 3,
            Name = "Rufa",
            Surname = "Yasamal",
            Birthday = new(2007, 01, 10)
        };

        return new Doctors[] { doctor1, doctor2, doctor3 };
    }

    public Doctors[] GetByBirthday(DateTime startDate, DateTime endDate)
    {
        Doctors[] doctors = GetAll();

        var result = doctors.Where(x => x.Birthday > startDate && x.Birthday < endDate).ToArray();

        return result;
    }
}

