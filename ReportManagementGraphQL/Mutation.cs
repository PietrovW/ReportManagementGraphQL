using System;
using HotChocolate;
using HotChocolate.Subscriptions;
using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Repositorys;
using ReportManagementGraphQL.Services;

namespace ReportManagementGraphQL
{
    public class Mutation
    {
            public List<User> AllUers([Service] IUserRepository userRepository) =>
             userRepository.GetAll();

            public async Task<User> CreateUser([Service] IUserRepository userRepository,
                [Service] ITopicEventSender eventSender, string email, string userName)
            {
                var newUser = new User
                {
                    Email=email,
                    UserName= userName
                };
                var createdUser = userRepository.CreateUser(newUser);

                await eventSender.SendAsync("UserCreated", createdUser);

                return createdUser;
            }
        



        /*
        public async Task<List<User>> GetUsers([Service] IUserRepository repository)
        => await repository.GetAll();

        public async Task<ICollection<ReportItem>> GetReportsAsync(
        [Service] ReportService service,
        CancellationToken cancellationToken)
        {
            return null;// service.GetAllAsync(cancellationToken);
        }

        public Task<ReportItem> GetReportByUserIdAsync(
            [Service] IReportService service,
            long idUser,
            CancellationToken cancellationToken)
        {
            return null;// service.GetByIdAsync(id, cancellationToken);
        }
        */
    }
}

