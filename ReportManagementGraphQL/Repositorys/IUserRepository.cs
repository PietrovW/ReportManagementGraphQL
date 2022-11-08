using System;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys
{
	public interface IUserRepository
	{
		List<User> GetAll();
		User CreateUser(User user);
		User GetUserById(Guid userId);
	}
}

