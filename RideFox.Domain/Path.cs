using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Path")]
public class Path : BaseEntity
{
	#region Fields

	[Required] public Parking From { get; set; }
	[Required] public Parking To { get; set; }
	public decimal PathLength { get; set; }

	#endregion
}
