using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Payloads;
using ReportManagementGraphQL.Querys;
using ReportManagementGraphQL.Repositorys;

namespace ReportManagementGraphQL.Mutations;
public sealed class Mutation
    {
        private readonly IUserRepository _userRepository;
        public Mutation(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<UserPayload> CreateUser(UserInput input)
        {
            var createdUser = await _userRepository.CreateUserAsync(new User(){ Id = Guid.NewGuid(),UserName =input.userName,Email=input.email, CreatedOn = DateTime.UtcNow});
            await _userRepository.SaveChangesAsync();

            return new UserPayload(createdUser);
            //await eventSender.SendAsync("UserCreated", createdUser);
        }
    }
