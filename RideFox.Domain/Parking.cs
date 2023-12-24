using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Parking")]
public class Parking : BaseEntity
{
	#region Fields
	
	[Required] public Address Address { get; set; }
	[Required] public ICollection<Scooter> Scooters { get; set; }

	#endregion
}
