using ReportManagementGraphQL.Data;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys;
public class ReportRepository : IReportRepository
	{
		private readonly ReportDbContext _reportDbContext;
		public ReportRepository(ReportDbContext reportDbContext)
		{
			_reportDbContext = reportDbContext;
		}

        public async Task<List<ReportItem>> GetAll()
		{
            return await _reportDbContext.ReportItems.ToListAsync();
		}
	}

