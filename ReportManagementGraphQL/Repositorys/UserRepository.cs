using System;
using Microsoft.EntityFrameworkCore;
using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys
{
    public class UserRepository : IUserRepository
	{
		private readonly ReportDbContext _reportDbContext;
		public UserRepository(ReportDbContext reportDbContext)
		{
			_reportDbContext = reportDbContext;
		}

		public List<User> GetAll()
		{
            return _reportDbContext.Users.ToList();
		}

		public User CreateUser(User user)
		{
		  var userNew=	_reportDbContext.Users.Add(user);
			return userNew.Entity;
		}

		public User GetUserById(Guid userId)
        {
			return _reportDbContext.Users.SingleOrDefault(u=>u.Id == userId);

		}
	}
}

