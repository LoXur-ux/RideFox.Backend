using AutoMapper;
using RideFox.Application.Common.Mapping;
using RideFox.Domain;
using RideFox.Domain.Statuses;

namespace RideFox.Application.Feature.Scooters.Queries.GetScooters;
public class ScooterVm : IMapWith<Scooter>
{
	public Guid Id { get; set; }
	public string ScooterName { get; set; }
	public ScooterStatus Status { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<Scooter, ScooterVm>()
			.ForMember(scooterVm => scooterVm.Id, scooter => scooter.MapFrom(scooter => scooter.Id))
			.ForMember(scooterVm => scooterVm.ScooterName, scooter => scooter.MapFrom(scooter => scooter.ScooterName))
			.ForMember(scooterVm => scooterVm.Status, scooter => scooter.MapFrom(scooter => scooter.Status));
	}
}
