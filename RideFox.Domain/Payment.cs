using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RideFox.Domain.Base;

namespace RideFox.Domain;

[Table("Payment")]
public class Payment : BaseEntity
{
	#region Fields

	[Required] public string PaymentLink { get; set; }
	[Required] public decimal Price { get; set; }
	[Required] public DateTime? TimePayment { get; set; }

	#endregion
}
