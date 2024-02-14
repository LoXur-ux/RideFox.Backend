using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Penalty"/>
/// </summary>
public class PenaltyConfiguration : IEntityTypeConfiguration<Penalty>
{
	public void Configure(EntityTypeBuilder<Penalty> builder)
	{
		builder.HasKey(x => x.Id);
		builder.HasIndex(x => x.Link).IsUnique();
		builder.Property(x => x.Description).HasMaxLength(600);
	}
}
