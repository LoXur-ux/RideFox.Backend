using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class AddressConfigurations : IEntityTypeConfiguration<Address>
{
	public void Configure(EntityTypeBuilder<Address> builder)
	{
		builder.HasKey(a => a.Id);
		builder.HasIndex(a => a.Id).IsUnique();
		builder.Property(a => a.Town).HasMaxLength(80);
		builder.Property(a => a.Street).HasMaxLength(120);
		builder.Property(a => a.Number).HasMaxLength(10);
		builder.Property(a => a.Build).HasMaxLength(10);
	}
}
