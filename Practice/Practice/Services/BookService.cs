using System;
using Practice.Models;
namespace Practice.Services
{
	public class BookService
	{
		private Book[] GetAll()
		{

			Book book1 = new()
			{
				id = 1,
				Name = "Outliers",
				Author = "Malcolm",
				PageCount = 138
			};

			Book book2 = new()
			{
				id = 2,
				Name = "Subconscious mind",
				Author = "Murphy",
				PageCount = 150
			};

			Book book3 = new()
			{
				id = 3,
				Name = "HP",
				Author = "J.K.Rowling",
				PageCount = 400
			};

			return new Book[] { book1, book2, book3 };

		}

		public Book[] GetByAuthor(string author)
		{
			Book[] books = GetAll();

			Book[] filteredBooks = books.Where(x => x.Author == author).ToArray();

			return filteredBooks;
		}


		public Book GetById(int id)
		{

			Book[] books = GetAll();

			Book book = books.FirstOrDefault(x => x.id == id);

			return book;

		}


		public Book[] SearchByName(string searchName)
		{
			return GetAll().Where(x => x.Name.ToLower().Contains(searchName)).ToArray();
		}


	

	}
}

