using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Path = RideFox.Domain.Path;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class PathConfiguration : IEntityTypeConfiguration<Path>
{
	public void Configure(EntityTypeBuilder<Path> builder) => builder.HasKey(x => x.Id);
}
