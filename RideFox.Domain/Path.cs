using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideFox.Domain;

[Table("Path")]
public class Path : BaseEntity
{
	#region Fields

	[Required] public Parking From { get; set; }
	[Required] public Parking To{ get; set; }
	public decimal PathLength { get; set; }

	#endregion

	#region Constructors

	public Path()
	{
	}

	public Path(Guid id, Parking addressFrom, Parking addressTo)
	{
		Id = id;
		From = addressFrom;
		To = addressTo;
	}

	#endregion
}
