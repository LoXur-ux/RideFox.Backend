using System.ComponentModel.DataAnnotations;

namespace RideFox.Domain;
public class Service : BaseEntity
{
	#region Fields

	[Required] public Scooter Scooter { get; set; }
	[Required] public Staff Staff { get; set; }
	[Required] public string Description { get; set; }
	[Required] public DateTime Start { get; set; } = DateTime.Now;
	public DateTime End { get; set; }

	#endregion

	#region Constructors

	public Service()
	{
	}

	public Service(Guid id, Scooter scooter, Staff staff, string description, DateTime start, DateTime end)
	{
		Id = id;
		Scooter = scooter;
		Staff = staff;
		Description = description;
		Start = start;
		End = end;
	}

	#endregion
}
