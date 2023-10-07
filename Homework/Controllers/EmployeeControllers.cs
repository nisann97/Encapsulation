using System;
using  Homework.Services;
using Homework.Models;

namespace Homework.Controllers;

public class EmployeeControllers
{
    public void GetBySalary()
    {
        EmployeeServices employeeService = new();


        Employee[] employees = employeeService.GetBySalary(1000, 2000);

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Name + " " + employee.Surname);
        }

    }
}

