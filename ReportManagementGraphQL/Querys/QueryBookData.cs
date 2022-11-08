using System;
namespace ReportManagementGraphQL.Querys
{
	public class QueryBookData
	{
		public Book GetBook()
		{
			return new Book { Title = "C# in depth", Author = new Author() { Name = "Jon Skeet" } };
		}
	}
}

