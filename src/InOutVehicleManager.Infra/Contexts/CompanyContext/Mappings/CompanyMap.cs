using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
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
    }
}
