﻿using System;
namespace Practice.Models
{
	public class Book : BaseEntity
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public int PageCount { get; set; }
	}
}

