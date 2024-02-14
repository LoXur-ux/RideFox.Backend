using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;

/// <summary>
/// Класс конфигурации типа <see cref="Staff">
/// </summary>
public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
	public void Configure(EntityTypeBuilder<Staff> builder) => builder.HasKey(x => x.Id);
}
