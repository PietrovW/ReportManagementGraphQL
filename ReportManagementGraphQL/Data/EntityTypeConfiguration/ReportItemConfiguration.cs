using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Data.EntityTypeConfiguration
{
	public class ReportItemConfiguration : IEntityTypeConfiguration<ReportItem>
	{
        public void Configure(EntityTypeBuilder<ReportItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Title)
                    .IsRequired()
                    .HasColumnName("Title")
                    .ValueGeneratedOnAddOrUpdate();
            builder.Property(t => t.CreatedOn)
                    .IsRequired()
                    .HasColumnName("created_on")
                    .ValueGeneratedOnAddOrUpdate();
            builder.Property(t => t.IsCompleted)
                    .IsRequired()
                    .HasColumnName("is_completed")
                    .ValueGeneratedOnAddOrUpdate();
            builder.HasOne(e => e.User)
                    .WithMany(c => c.Reports);
            builder.Property(a => a.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate();
        }
    }
}

