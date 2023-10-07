using System;
namespace Practice.Models
{
	public class StudentServices
	{
		private Student[] GetAllStudents()
		{
			Student student1 = new()
			{
				name = "Nisa",
				surname = "Narimanova",
				email = "nnarimanova2020@Ada.edu.az",
				id = 1,
				birthday = new(1997, 12, 31)
			};

			Student student2 = new()
			{
				name = "Rafig",
				surname = "Mammadli",
				email = "mammadli@gmail.com",
				id = 2,
				birthday = new(1997, 04, 11)
			};

			Student student3 = new()
			{
				name = "Khadija",
				surname = "Jahangirova",
				email = "jahangirova@gmail.com",
				id = 3,
				birthday = new(2004, 01, 18)
			};

			return new Student[] { student1, student2, student3 };
		}


		public Student[] GetStudentsByDate(DateTime startDate, DateTime endDate)
		{
			Student[] students = GetAllStudents();

			var result = students.Where(x => x.birthday > startDate && x.birthday < endDate).ToArray();

			return result; 

		}


		public int GetStudentAgeById(int id)
		{
			Student[] students = GetAllStudents();

			Student student = students.FirstOrDefault(x => x.id == id);

			int result = DateTime.Now.Year - student.birthday.Year;

			return result;
		}

	}


}

