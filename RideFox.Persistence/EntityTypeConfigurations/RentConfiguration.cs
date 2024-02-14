using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Rent"/>
/// </summary>
public class RentConfiguration : IEntityTypeConfiguration<Rent>
{
	public void Configure(EntityTypeBuilder<Rent> builder) => builder.HasKey(x => x.Id);
}
