using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Client")]
public class Client : BaseEntity
{
	#region Fields

	[Required] public Person Person { get; set; }
	[Required] public int RentCount { get; set; } = 0;
	[Required] public ICollection<Rent> Rents { get; set; }
	public virtual ICollection<Staff> Penalties { get; set; }

	#endregion
}
