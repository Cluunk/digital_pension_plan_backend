using DigitalPensionPlanDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalPensionPlanInfrastructure.Persistance.Configurations
{
    public class HostConfiguration : IEntityTypeConfiguration<Host>
    {
        public void Configure(EntityTypeBuilder<Host> builder)
        {
            builder.ToTable("hosts");

            builder.HasKey(e => e.HostId);

            builder.Property(e => e.HostId)
                .HasDefaultValueSql("uuidv7()")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UserRoleId)
                .IsRequired();

            builder.Property(e => e.HostName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.PasswordHash)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
