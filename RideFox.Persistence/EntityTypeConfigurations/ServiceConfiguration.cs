using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Service"/>
/// </summary>
public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
	public void Configure(EntityTypeBuilder<Service> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Description).HasMaxLength(600);
	}
}
