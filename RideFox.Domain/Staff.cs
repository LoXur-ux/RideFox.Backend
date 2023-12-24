using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;
using RideFox.Domain.Statuses;

namespace RideFox.Domain;

[Table("Staff")]
public class Staff : BaseEntity
{
	#region Fields

	[Required] public Person Person { get; set; }
	[Required] public StaffRole Role { get; set; }
	public ICollection<Service> Services { get; set; }

	#endregion
}
