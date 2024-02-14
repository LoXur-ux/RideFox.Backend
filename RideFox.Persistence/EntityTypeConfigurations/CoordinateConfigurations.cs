using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Coordinate"/>
/// </summary>
public class CoordinateConfigurations : IEntityTypeConfiguration<Coordinate>
{
	public void Configure(EntityTypeBuilder<Coordinate> builder) => builder.HasKey(x => x.Id);
}
