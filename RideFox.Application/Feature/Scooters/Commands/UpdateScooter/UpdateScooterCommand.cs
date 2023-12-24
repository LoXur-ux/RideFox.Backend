using MediatR;
using RideFox.Domain;
using RideFox.Domain.Statuses;

namespace RideFox.Application.Feature.Scooters.Commands.UpdateScooter;
public class UpdateScooterCommand : IRequest<Guid>
{
	public Guid Id { get; set; }
	public string ScooterName { get; set; }
	public ScooterStatus Status { get; set; }
	public ICollection<Rent> Rents { get; set; }
	public ICollection<Service> Services { get; set; }

}
