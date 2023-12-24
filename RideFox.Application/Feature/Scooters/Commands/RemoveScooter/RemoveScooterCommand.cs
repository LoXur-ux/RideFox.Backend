using MediatR;

namespace RideFox.Application.Feature.Scooters.Commands.RemoveScooter;
public class RemoveScooterCommand : IRequest<Unit>
{
	public Guid Id { get; set; }
}
