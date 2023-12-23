using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideFox.Domain;

[Table("Client")]
public class Client : Human
{
	#region Fields
	[Required] public int RentCount { get; set; } = 0;
	[Required] public ICollection<Rent> Rents { get; set; }
	public virtual ICollection<Penalty> Penalties { get; set; }

	#endregion
	#region Constructors
	public Client() { }
	public Client(string login, string password, string email, string phoneNumber, DateTime dateOfRegister,
		string firstName, string lastName, string middleName, DateOnly birthday, ICollection<Rent> rents)
	: base(login, password, email, phoneNumber, dateOfRegister, firstName, lastName, middleName, birthday)
	{
		RentCount = 0;
		Rents = rents ?? new List<Rent>();
	}

	#endregion
	#region Methods
	#endregion
}
