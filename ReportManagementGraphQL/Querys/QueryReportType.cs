using System;
using HotChocolate;
using HotChocolate.Subscriptions;
using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Repositorys;
using ReportManagementGraphQL.Services;

namespace ReportManagementGraphQL.Querys
{
    public class QueryReportType
    {


        public List<User> AllUsers([Service] IUserRepository userRepository)
        { 
       return userRepository.GetAll();
        }



        public async Task<User> GetUserById([Service] IUserRepository userRepository,
            [Service] ITopicEventSender eventSender, Guid id)
        {
            User user = userRepository.GetUserById(id);
            await eventSender.SendAsync("ReturnedUser", user);
            return user;
        }

        // [UseFiltering]
        //public Task<ICollection<ReportItem>> GetReportsAsync(
        //[Service] ReportService service,
        //CancellationToken cancellationToken)
        //{
        //  return null;// service.GetAllAsync(cancellationToken);
        //}

        //        public Task<ReportItem> GetReportByUserIdAsync(
        //          [Service] IReportService service,
        //        long idUser,
        //      CancellationToken cancellationToken)
        // {
        //   return null;// service.GetByIdAsync(id, cancellationToken);
        //}


        //[UseDbContext(typeof(ReportDbContext))]
        //  public IQueryable<ReportItem> GetTodoItems([ScopedService]
        // ReportDbContext context) => context.TodoItems;
    }
}

