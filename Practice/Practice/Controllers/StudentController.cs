using System;
using Practice.Models;

namespace Practice.Controllers
{
    public class StudentController
    {

        public void GetFilteredStudents()
        {
            DateTime startDate = new(1997, 01, 01);
            DateTime endDate = new(2000, 01, 01);


            StudentServices studentservice = new();

            Student[] students = studentservice.GetStudentsByDate(startDate, endDate);

            foreach (var student in students)
            {
                var result = student.name + " " + student.birthday.ToString("MM/dd/yyyy");

                Console.WriteLine(result);
            }
        }


        public void GetStudentAge()
        {
            StudentServices studentService = new();

            Console.WriteLine(studentService.GetStudentAgeById(2));
        }

    }
}

