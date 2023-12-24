using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Sevice")]
public class Service : BaseEntity
{
	#region Fields

	[Required] public Scooter Scooter { get; set; }
	[Required] public Staff Staff { get; set; }
	[Required] public string Description { get; set; }
	[Required] public DateTime Start { get; set; } = DateTime.Now;
	public DateTime End { get; set; }

	#endregion
}
