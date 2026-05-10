using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalPensionPlanInfrastructure.Persistance
{
    public class PhaseConfiguration : IEntityTypeConfiguration<Phase>
    {
        public void Configure(EntityTypeBuilder<Phase> builder)
        {
            builder.ToTable("phases");

            builder.HasKey(e => e.PhaseId);

            builder.Property(e => e.PhaseId)
                .HasDefaultValueSql("uuidv7()")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.PhaseName)
                .HasMaxLength(25);
        }
    }
}
