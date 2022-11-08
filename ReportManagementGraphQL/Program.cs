using HotChocolate.Subscriptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportManagementGraphQL;
using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Querys;
using ReportManagementGraphQL.Repositorys;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReportDbContext>(opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));
builder.Services.AddTransient<IReportRepository, ReportRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddMemoryCache();
builder.Services.AddInMemorySubscriptions();
builder.Services.AddGraphQLServer()
    .AddQueryType<QueryReportType>()
    .AddMutationType<MutationType>()
    .AddSubscriptionType<Subscription>();
   // .AddMutationType<MutationType>();
   // .AddQueryType<QueryData>();
   //.AddQueryType<UserType>()
    //.AddObjectType<ReportItemType>()
   // .AddMutationType<Mutation>()
    //.AddSubscriptionType<Subscription>()
   // .AddInMemorySubscriptions(); 

  //  .UseAutomaticPersistedQueryPipeline();
   


var app = builder.Build();

app.UseWebSockets();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();

