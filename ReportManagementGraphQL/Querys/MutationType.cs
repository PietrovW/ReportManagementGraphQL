using System;
using HotChocolate.Subscriptions;
using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Payloads;
using ReportManagementGraphQL.Repositorys;

namespace ReportManagementGraphQL.Querys
{
    public class User2
    {
        public string Name { get; set; }
    }

    public class MutationType
    { 

        public async Task<User> CreateUser([Service] IUserRepository userRepository,
            string email, string userName)
        {
            User? newUser = new User()
            {
                Email = email,
                UserName = userName
            };
            var createdUser = userRepository.CreateUser(newUser);

            //await eventSender.SendAsync("UserCreated", createdUser);

            return createdUser;//new User2() { Name="dupa"};
        }
    }
}

