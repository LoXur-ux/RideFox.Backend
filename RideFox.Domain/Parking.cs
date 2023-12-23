using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideFox.Domain;

[Table("Parking")]
public class Parking : BaseEntity
{
	#region Fields
	
	[Required] public Address Address { get; set; }
	[Required] public ICollection<Scooter> Scooters { get; set; }

	#endregion

	#region Constructors

	public Parking()
	{
	}

	public Parking(Guid id, Address address, ICollection<Scooter> scooters)
	{
		Id = id;
		Address = address;
		Scooters = scooters ?? new List<Scooter>();
	}

	#endregion
}
