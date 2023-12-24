using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Address")]
public class Address : BaseEntity
{
	#region Fields

	public string Town { get; set; }
	public string Street { get; set; }
	public string Number { get; set; }
	public string Build { get; set; }
	[Required] public Coordinate Coordinate { get; set; }

	#endregion
}
