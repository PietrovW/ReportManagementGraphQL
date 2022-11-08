using System;
using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Repositorys;

namespace ReportManagementGraphQL.Querys
{
    public class Author
    {
        public string Name { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }

        public Author Author { get; set; }
    }
    public class QueryData
    {
        private readonly IReportRepository _repository;
        public QueryData(IReportRepository repository)
        {
            _repository= repository;
        }

        public async Task<List<ReportItem>> GetReportItem()
        {
            return await _repository.GetAll();
        }

        public Book GetBook()
        {
            return new Book
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };
        }
            
    }
}

