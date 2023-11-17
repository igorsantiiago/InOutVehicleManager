using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InOutVehicleManager.Infra;

public class ParkingMap : IEntityTypeConfiguration<Parking>
{
    public void Configure(EntityTypeBuilder<Parking> builder)
    {
        builder.ToTable("Parking");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.AvailableCarParkingSpaces).HasColumnName("AvailableCarSpaces").HasColumnType("INT").IsRequired();

        builder.Property(x => x.AvailableMotorcycleParkingSpaces).HasColumnName("AvailableMotorcycleSpaces").HasColumnType("INT").IsRequired();
    }
}
