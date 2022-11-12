using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys;
public interface IUserRepository
	{
		Task<List<User>> GetAllAsync();
		Task<User> CreateUserAsync(User user);
		User GetUserById(Guid userId);
		Task<int> SaveChangesAsync();
	}

