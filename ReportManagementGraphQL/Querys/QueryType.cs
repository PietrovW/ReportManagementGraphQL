namespace ReportManagementGraphQL.Querys
{
    public class QueryType : ObjectType<QueryBookData>
    {
        protected override void Configure(IObjectTypeDescriptor<QueryBookData> descriptor)
        {
            descriptor
                .Field(f => f.GetBook())
                .Type<BookType>();
        }
    }
}

