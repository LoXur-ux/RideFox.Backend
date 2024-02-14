using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Parking"/>
/// </summary>
public class ParkingConfiguration : IEntityTypeConfiguration<Parking>
{
	public void Configure(EntityTypeBuilder<Parking> builder) => builder.HasKey(x => x.Id);
}
