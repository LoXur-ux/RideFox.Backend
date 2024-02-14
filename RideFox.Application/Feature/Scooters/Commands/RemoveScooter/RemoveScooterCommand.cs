using MediatR;

namespace RideFox.Application.Feature.Scooters.Commands.RemoveScooter;
public class RemoveScooterCommand : IRequest<Unit>
{
	public Guid UserId { get; set; }
	public Guid Id { get; set; }
}
