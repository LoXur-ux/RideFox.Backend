using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Statuses;

namespace RideFox.Domain;

[Table("Rent")]
public class Rent : BaseEntity
{
	#region Field

	[Required] public Client Client { get; set; }
	[Required] public Scooter Scooter { get; set; }
	[Required] public Payment Payment { get; set; }
	[Required] public Path Path { get; set; }
	[Required] public RentStatus Status { get; set; } = RentStatus.Active;
	[Required] public DateTime Start { get; set; } = DateTime.Now;
	public DateTime? End { get; set; } = null;

	#endregion

	#region Constructors

	public Rent() { }
	public Rent(Guid id, Client client, Scooter scooter, RentStatus status)
	{
		Id = id;
		Client = client;
		Scooter = scooter;
		Start = DateTime.Now;
		Status = status;
	}

	#endregion

	#region Methods

	public void SetEndDate(DateTime date) => End = date;

	#endregion
}
