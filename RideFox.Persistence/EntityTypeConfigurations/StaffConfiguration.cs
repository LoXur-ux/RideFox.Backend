using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
	public void Configure(EntityTypeBuilder<Staff> builder) => builder.HasKey(x => x.Id);
}
