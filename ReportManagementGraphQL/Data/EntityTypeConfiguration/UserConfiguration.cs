using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Data.EntityTypeConfiguration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.CreatedOn)
                    .IsRequired()
                    .HasColumnName("created_on")
                    .ValueGeneratedOnAdd();
            builder.Property(t => t.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode()
                    .HasColumnName("user_name");
            builder.Property(t => t.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode()
                    .HasColumnName("email");
            //builder.HasMany(c => c.Reports)
              //      .WithOne(e => e.User);
            builder.Property(t => t.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate();
        }
    }
}

