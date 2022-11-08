using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Payloads;
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
            var createdUser = await _userRepository.CreateUserAsync(new User(){ UserName =input.userName,Email=input.email });

            //await eventSender.SendAsync("UserCreated", createdUser);

            return new UserPayload(createdUser);
        }
    }
