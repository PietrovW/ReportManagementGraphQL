using HotChocolate.Data.Filters;

namespace ReportManagementGraphQL.Querys;

public class ReportFilterType: FilterInputType<ReportInput>
{
    protected override void Configure(
        IFilterInputTypeDescriptor<ReportInput> descriptor)
    {
        descriptor
            .BindFieldsExplicitly()
            .Field(t => t.Title)
            .AllowEquals().Name("equals")
            .AllowContains().Name("contains")
            .AllowIn().Name("in");
    }
}