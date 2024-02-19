using AutoMapper;
using RideFox.Application.Common.Mapping;
using RideFox.Domain;
using RideFox.Domain.Statuses;

namespace RideFox.Application.Feature.Scooters.Queries.GetScootersList;

public class ScooterVm : IMapWith<Scooter>
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public ScooterStatus Status { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<Scooter, ScooterVm>()
			.ForMember(scooterVm => scooterVm.Id, scooter => scooter.MapFrom(scooter => scooter.Id))
			.ForMember(scooterVm => scooterVm.Name, scooter => scooter.MapFrom(scooter => scooter.Name))
			.ForMember(scooterVm => scooterVm.Status, scooter => scooter.MapFrom(scooter => scooter.Status));
	}
}
