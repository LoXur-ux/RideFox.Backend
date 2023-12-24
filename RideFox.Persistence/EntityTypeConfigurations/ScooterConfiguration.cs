using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class ScooterConfiguration : IEntityTypeConfiguration<Scooter>
{
	public void Configure(EntityTypeBuilder<Scooter> builder)
	{
		builder.HasKey(x => x.Id);
		builder.HasIndex(x => x.ScooterName).IsUnique();
	}
}
