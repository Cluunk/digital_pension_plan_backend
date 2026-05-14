using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Persistance
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("genders");

            builder.HasKey(e => e.GenderId);

            builder.Property(e => e.GenderId)
                .HasDefaultValueSql("uuidv7()")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.GenderDescription)
                .HasMaxLength(20);
        }
    }
}
