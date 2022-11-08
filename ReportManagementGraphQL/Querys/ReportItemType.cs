using HotChocolate.Types;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Querys
{
	public class ReportItemType : ObjectType<ReportItem>
    {
        protected override void Configure(IObjectTypeDescriptor<ReportItem> descriptor)
        {
            descriptor
             .Description("The title of the todo item")
             .Field(f => f.Title)
             .Type<StringType>();

            descriptor
              .Name("User")
              .Field(f => f.User)
              .Type<UserType>();

            descriptor
             .Field(f => f.CreatedOn)
             .Type<StringType>();
        }
    }
}

