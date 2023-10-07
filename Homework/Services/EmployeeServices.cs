using System;
using Homework.Models;
namespace Homework.Services;

public class EmployeeServices
{
    private Employee[] GetAll()
    {
        Employee employee1 = new()
        {
            Id = 1,
            Name = "Nisa",
            Surname = "Narimanova",
            Age = 26,
            Salary = 1900
        };

        Employee employee2 = new()
        {
            Id = 2,
            Name = "Rafig",
            Surname = "Mammadli",
            Age = 26,
            Salary = 2200
        };

        Employee employee3 = new()
        {
            Id = 3,
            Name = "Rufa",
            Surname = "Ahmadova",
            Age = 30,
            Salary = 1550
        };

        Employee employee4 = new()
        {
            Id = 4,
            Name = "Irana",
            Surname = "Narimanova",
            Age = 23,
            Salary = 700
        };

        return new Employee[] { employee1, employee2, employee3, employee4 };
    }


    public Employee[] GetBySalary(int a, int b)
    {
        Employee[] employees = GetAll();

        Employee[] filteredEmployee = employees.Where(x => x.Salary > a && x.Salary < b).ToArray();

        return filteredEmployee;
    }
}

