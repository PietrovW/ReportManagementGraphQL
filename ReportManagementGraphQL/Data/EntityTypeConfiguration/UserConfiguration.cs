<<<<<<< HEAD
﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
=======
﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
>>>>>>> ec9733f (commit)
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
                    .ValueGeneratedOnAddOrUpdate();
            builder.Property(t => t.UserName)
                    .IsRequired()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("user_name");
            builder.Property(t => t.Email)
                    .IsRequired()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("email");
            builder.HasMany(c => c.Reports)
                    .WithOne(e => e.User);
          //  builder.Property(a => a.RowVersion)
            //        .IsRowVersion()
              //      .IsConcurrencyToken()
                //    .ValueGeneratedOnAddOrUpdate();
        }
    }
}

