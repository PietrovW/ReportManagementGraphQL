using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys;
public class UserRepository : IUserRepository
	{
		private readonly ReportDbContext _reportDbContext;
		public UserRepository(IDbContextFactory<ReportDbContext> reportDbContext)
		{
			_reportDbContext = reportDbContext.CreateDbContext();
		}

		public async Task<List<User>> GetAllAsync()
		{
            return await _reportDbContext.Users.ToListAsync();
		}

		public async Task<User> CreateUserAsync(User user)
		{
		  var userNew=await _reportDbContext.Users.AddAsync(user);
		  
			return userNew.Entity;
		}

		public User GetUserById(Guid userId)
        {
			return _reportDbContext.Users.SingleOrDefault(u=>u.Id == userId);
        }

		public async Task<int> SaveChangesAsync()
		{
		return	await _reportDbContext.SaveChangesAsync();
		}
		
	}

