using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideFox.Domain;

namespace RideFox.Persistence.EntityTypeConfigurations;
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
	public void Configure(EntityTypeBuilder<Person> builder)
	{
		builder.HasKey(x => x.Id);
		builder.HasIndex(x => x.Login).IsUnique();
		builder.HasIndex(x => x.PhoneNumber).IsUnique();
	}
}
