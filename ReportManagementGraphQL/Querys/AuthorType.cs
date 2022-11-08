using System;
namespace ReportManagementGraphQL.Querys
{
	public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor
                .Field(f => f.Name)
                .Type<StringType>();
        
		}
	}
}

