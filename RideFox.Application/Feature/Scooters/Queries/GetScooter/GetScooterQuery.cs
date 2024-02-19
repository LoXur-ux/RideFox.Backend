using MediatR;
using RideFox.Application.Feature.Scooters.Queries.GetScootersList;

namespace RideFox.Application.Feature.Scooters.Queries.GetScooter;

public class GetScooterQuery : IRequest<ScooterVm>
{
	public Guid Id { get; set; }
}
