using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InOutVehicleManager.Infra;

public class VehicleMap : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable("Vehicle");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Model).HasColumnName("Model").HasColumnType("NVARCHAHR").HasMaxLength(30).IsRequired();

        builder.Property(x => x.Brand).HasColumnName("Brand").HasColumnType("NVARCHAR").HasMaxLength(30).IsRequired();

        builder.Property(x => x.Color).HasColumnName("Color").HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired();

        builder.Property(x => x.LicensePlate).HasColumnName("LicensePlate").HasColumnType("NVARCHAR").HasMaxLength(12).IsRequired();

        builder.Property(x => x.Type).HasColumnName("Type").HasColumnType("NVARCHAR").HasMaxLength(12).IsRequired();
    }
}
