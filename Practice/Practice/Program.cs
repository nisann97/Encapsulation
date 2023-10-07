using Practice.Models;




//GetFilteredStudents();



//GetStudentAge();



//Car car = new()
//{
//    color = "Red",
//    speed = 500,
//    Vin = "nisa"
//};

//Console.WriteLine(car.Vin);

//using Practice.Controllers;

//StudentController studentController = new();

//studentController.GetFilteredStudents();
//studentController.GetStudentAge();


using Practice.Controllers;

BookController bookController = new();

//bookController.GetAllByAuthor();

//bookController.GetBookById();

bookController.Search();