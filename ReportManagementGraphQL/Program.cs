using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Mutations;
using ReportManagementGraphQL.Querys;
using ReportManagementGraphQL.Repositorys;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("DbDatabase");
builder.Services.AddDbContextFactory<ReportDbContext>(options =>
 options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddTransient<IReportRepository, ReportRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddInMemorySubscriptions();
builder.Services.AddGraphQLServer()
 .AddQueryType<QueryReportType>()
 .AddMutationType<Mutation>();
var app = builder.Build();
app.MapGraphQL();
app.Run();

