using System;
using HotChocolate.Types;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Querys
{
	public class UserType : ObjectType<User>
	{
		protected override void Configure(IObjectTypeDescriptor<User> descriptor)
		{
			descriptor.Name("User");
			descriptor.Description("An object type");

			descriptor
			 .Field(f => f.Email)
			 .Type<StringType>();

			descriptor
			 .Field(f => f.UserName)
			 .Description("User Name")
			 .Type<StringType>();

			descriptor
			 .Field(f => f.Id)
			 .Description("Id User")
			 .Type<IntType>();

			descriptor
			 .Field(f => f.CreatedOn)
			 .Type<DateTimeType>();
		}
	}
}

