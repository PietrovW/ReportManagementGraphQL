using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys;
public class ReportRepository : IReportRepository
	{
		private readonly ReportDbContext _context;
		public ReportRepository(IDbContextFactory<ReportDbContext> _contextFactory)
		{
			_context = _contextFactory.CreateDbContext();
		}

        public async Task<List<ReportItem>> GetAll()
		{
            return await _context.ReportItems.ToListAsync();
		}
	}

