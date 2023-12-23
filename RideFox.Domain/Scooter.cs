using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Statuses;

namespace RideFox.Domain;

[Table("Scooter")]
public class Scooter : BaseEntity
{
	#region Fields

	[Required] public string ScooterName { get; set; }
	[Required] public DateTime DateOfCommissioning { get; set; } = DateTime.Now;
	[Required] public ScooterStatus Status { get; set; } = ScooterStatus.Available;
	[Required] public ICollection<Rent> Rents { get; set; }
	[Required] public ICollection<Service> Services { get; set; }

	#endregion

	#region Constructors

	public Scooter() { }
	public Scooter(Guid id, string scooterName, DateTime dateOfCommissioning,
		ScooterStatus status, ICollection<Rent> rents, ICollection<Service> services)
	{
		Id = id;
		ScooterName = scooterName;
		DateOfCommissioning = dateOfCommissioning;
		Status = status;
		Rents = rents ?? new List<Rent>();
		Services = services;
	}
	#endregion
}