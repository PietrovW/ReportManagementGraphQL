using System;
namespace ReportManagementGraphQL.Querys
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor
                .Field(f => f.Title)
                .Type<StringType>();

            descriptor
                .Field(f => f.Author)
                .Type<AuthorType>();
        }
    }
}

