using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;
using RideFox.Domain.Statuses;

namespace RideFox.Domain;

[Table("Scooter")]
public class Scooter : BaseEntity
{
	#region Fields

	[Required] public string ScooterName { get; set; }
	[Required] public DateTime DateOfCommissioning { get; set; } = DateTime.Now;
	[Required] public ScooterStatus Status { get; set; } = ScooterStatus.Available;
	[Required] public Coordinate Coordinate { get; set; }
	public ICollection<Rent> Rents { get; set; }
	public ICollection<Service> Services { get; set; }

	#endregion
}