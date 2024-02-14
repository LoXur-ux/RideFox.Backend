using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Path = RideFox.Domain.Path;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Path"/>
/// </summary>
public class PathConfiguration : IEntityTypeConfiguration<Path>
{
	public void Configure(EntityTypeBuilder<Path> builder) => builder.HasKey(x => x.Id);
}
