using System;
using Practice.Services;
using Practice.Models;
namespace Practice.Controllers
	
{
	public class BookController
	{


		private BookService bookService;

		public BookController()
		{
			bookService = new();
		}





		public void GetAllByAuthor()
		{
			string author = "Malcolm";

			BookService bookService = new();

			Book[] result = bookService.GetByAuthor(author);

			foreach(var item in result)
			{
				Console.WriteLine(item.Name + " " + item.Author);
			}
		}


		public void GetBookById()
		{
			BookService bookService = new();

			var result = bookService.GetById(2);

			Console.WriteLine(result.Name + " " + result.Author + " " + result.PageCount);
		}

		public void Search()
		{

			BookService bookService = new();

			var result = bookService.SearchByName("t");

				foreach(var item in result)
			{

				Console.WriteLine(item.Name + " " + item.Author);

			}
		}
	}

}

