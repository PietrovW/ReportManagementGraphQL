using ReportManagementGraphQL.Data.Entity;
using ReportManagementGraphQL.Data.EntityTypeConfiguration;

namespace ReportManagementGraphQL.Data
{
	public class ReportDbContext : DbContext
	{
		public DbSet<ReportItem> ReportItems => Set<ReportItem>();

		public DbSet<User> Users => Set<User>();

		public ReportDbContext(DbContextOptions<ReportDbContext> options)
		: base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new ReportItemConfiguration());
		}
	}
}

