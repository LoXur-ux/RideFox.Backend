using System.ComponentModel.DataAnnotations;

namespace RideFox.Domain;
public abstract class BaseEntity
{
	[Key] public Guid Id { get; set; }
}
