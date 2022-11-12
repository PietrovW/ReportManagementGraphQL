namespace ReportManagementGraphQL.Querys;

public class QueryReportType: ObjectType<QueryReport>
{
    protected override void Configure(IObjectTypeDescriptor<QueryReport> descriptor)
    {
        descriptor.Field(t => t.AllUsers());
        descriptor.Field(t=>t.GetUserById(default));
    }
}