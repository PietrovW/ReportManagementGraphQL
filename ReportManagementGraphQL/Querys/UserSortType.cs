using HotChocolate.Data.Sorting;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Querys
{
    public class UserSortType : SortInputType<User>
    {
        protected override void Configure(ISortInputTypeDescriptor<User> descriptor)
        {
            //descriptor.BindFieldsExplicitly();
            descriptor.Field(f => f.UserName);
        }
    }
}

