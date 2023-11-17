using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InOutVehicleManager.Infra;

public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Role");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired();
    }
}
