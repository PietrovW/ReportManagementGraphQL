using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys
{
	public interface IUserRepository
	{
		List<User> GetAll();
		Task<User> CreateUserAsync(User user);
		User GetUserById(Guid userId);
		Task<int> SaveChangesAsync();
	}
}

