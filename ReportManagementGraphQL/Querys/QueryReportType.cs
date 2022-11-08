using HotChocolate.Subscriptions;
using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Repositorys;

namespace ReportManagementGraphQL.Querys
{
    public sealed class QueryReportType
    {
        private readonly IUserRepository _userRepository;
        private readonly ITopicEventSender _eventSender;
        public QueryReportType(IUserRepository userRepository,ITopicEventSender eventSender)
        {
            _userRepository = userRepository;
            _eventSender = eventSender;
        }
        public List<User> AllUsers()
        { 
          return _userRepository.GetAll();
        }
        
        public async Task<User> GetUserById(Guid id)
        {
            User user = _userRepository.GetUserById(id);
            await _eventSender.SendAsync("ReturnedUser", user);
            return user;
        }
    }
}

