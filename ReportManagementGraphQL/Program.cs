using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Mutations;
using ReportManagementGraphQL.Querys;
using ReportManagementGraphQL.Repositorys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReportDbContext>(opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));
builder.Services.AddTransient<IReportRepository, ReportRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddInMemorySubscriptions();
builder.Services.AddGraphQLServer()
 .AddQueryType<QueryReportType>()
 .AddMutationType<Mutation>();
var app = builder.Build();
app.MapGraphQL();
app.Run();

