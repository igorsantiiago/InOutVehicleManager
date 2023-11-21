using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InOutVehicleManager.Infra;

public class CompanyMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Company");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(40).IsRequired();

        builder.OwnsOne(x => x.Cnpj).Property(x => x.Document).HasColumnName("Document").HasColumnType("NVARCHAR").HasMaxLength(14).IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.ZipCode).HasColumnName("ZipCode").HasColumnType("NVARCHAR").HasMaxLength(8).IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.Street).HasColumnName("Street").HasColumnType("NVARCHAR").HasMaxLength(80).IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.AddressNumber).HasColumnName("AddressNumber").HasColumnType("INT").IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.AddressLine).HasColumnName("AddressLine").HasColumnType("NVARCHAR").HasMaxLength(40).IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.City).HasColumnName("City").HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired();

        builder.OwnsOne(x => x.Address).Property(x => x.State).HasColumnName("State").HasColumnType("NVARCHAR").HasMaxLength(15).IsRequired();

        builder.OwnsOne(x => x.Phone).Property(x => x.LandlinePhone).HasColumnName("LandlinePhone").HasColumnType("NVARCHAR").HasMaxLength(15).IsRequired();

        builder.OwnsOne(x => x.Phone).Property(x => x.MobilePhone).HasColumnName("MobilePhone").HasColumnType("NVARCHAR").HasMaxLength(15).IsRequired();

        builder.HasMany(x => x.Parking).WithMany(x => x.Companies).UsingEntity<Dictionary<string, object>>(
            "CompanyParking",
            parking => parking.HasOne<Parking>().WithMany().HasForeignKey("ParkingId").OnDelete(DeleteBehavior.Cascade),
            company => company.HasOne<Company>().WithMany().HasForeignKey("CompanyId").OnDelete(DeleteBehavior.Cascade)
        );

        builder.HasMany(x => x.Employees).WithMany(x => x.Companies).UsingEntity<Dictionary<string, object>>(
            "CompanyEmployee",
            employee => employee.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId").OnDelete(DeleteBehavior.Cascade),
            company => company.HasOne<Company>().WithMany().HasForeignKey("CompanyId").OnDelete(DeleteBehavior.Cascade)
        );
    }
}