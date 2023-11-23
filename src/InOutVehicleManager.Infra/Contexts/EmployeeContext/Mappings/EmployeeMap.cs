using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InOutVehicleManager.Infra;

public class EmployeeMap : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");
        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Name).Property(x => x.FirstName).HasColumnName("FirstName").HasColumnType("NVARCHAR").HasMaxLength(30).IsRequired();

        builder.OwnsOne(x => x.Name).Property(x => x.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR").HasMaxLength(30).IsRequired();

        builder.OwnsOne(x => x.Document).Property(x => x.Cpf).HasColumnName("CPF").HasColumnType("NVARCHAR").HasMaxLength(11).IsRequired();

        builder.OwnsOne(x => x.Email).Property(x => x.Address).HasColumnName("Address").HasColumnType("NVARCHAR").HasMaxLength(120).IsRequired();

        builder.OwnsOne(x => x.Password).Property(x => x.Hash).HasColumnName("PasswordHash").HasColumnType("NVARCHAR").HasMaxLength(255).IsRequired();

        builder.HasMany(x => x.Roles).WithMany(x => x.Employees).UsingEntity<Dictionary<string, object>>(
            "EmployeeRole",
            role => role.HasOne<Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.Cascade),
            employee => employee.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId").OnDelete(DeleteBehavior.Cascade)
        );
    }
}
