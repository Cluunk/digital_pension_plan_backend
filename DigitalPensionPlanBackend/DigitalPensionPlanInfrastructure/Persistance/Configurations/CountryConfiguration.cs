using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Persistance.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("countries");

            builder.HasKey(e => e.CountryId);

            builder.Property(e => e.CountryId)
                .HasDefaultValueSql("uuidv7()")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.CountryName)
                .HasMaxLength(50);
            builder.Property(e => e.CountryAbbreviation)
                .HasMaxLength(10);
        }
    }
}
