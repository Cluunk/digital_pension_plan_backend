using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Persistance.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("user_roles");

            builder.HasKey(e => e.UserRoleId);

            builder.Property(e => e.UserRoleId)
                .HasDefaultValueSql("uuidv7()")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UserRoleName)
                .HasMaxLength(20);
        }
    }
}
