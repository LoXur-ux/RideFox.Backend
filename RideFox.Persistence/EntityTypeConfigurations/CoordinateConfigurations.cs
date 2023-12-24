using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class CoordinateConfigurations : IEntityTypeConfiguration<Coordinate>
{
	public void Configure(EntityTypeBuilder<Coordinate> builder) => builder.HasKey(x => x.Id);
}
