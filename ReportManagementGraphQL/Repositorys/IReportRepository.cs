using System;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Repositorys
{
	public interface IReportRepository
	{
        Task<List<ReportItem>> GetAll();
	}
}

