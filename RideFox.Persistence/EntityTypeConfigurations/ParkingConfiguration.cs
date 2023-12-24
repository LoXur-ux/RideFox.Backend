using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class ParkingConfiguration : IEntityTypeConfiguration<Parking>
{
	public void Configure(EntityTypeBuilder<Parking> builder) => builder.HasKey(x => x.Id);
}
