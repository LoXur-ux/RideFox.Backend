using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;
using RideFox.Domain.Statuses;

namespace RideFox.Domain;

[Table("Penalty")]
public class Penalty : BaseEntity
{
	#region Fields

	[Required] public Client Client { get; set; }
	[Required] public string Link { get; set; }
	[Required] public DateTime Date { get; set; }
	[Required] public RentStatus State { get; set; }
	[Required] public Address Address { get; set; }
	[Required] public Address MVDAddress { get; set; }
	[Required] public string InspectorFIO { get; set; }
	[Required] public string Description { get; set; }

	#endregion
}
