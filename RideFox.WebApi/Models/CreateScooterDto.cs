using AutoMapper;
using RideFox.Application.Common.Mapping;
using RideFox.Application.Feature.Scooters.Commands.CreateScooter;
using RideFox.Domain.Statuses;

namespace RideFox.WebApi.Models;

public class CreateScooterDto : IMapWith<CreateScooterCommand>
{
	public string ScooterName { get; set; }
	public DateTime DateOfCommissioning {  get; set; }
	public ScooterStatus Status { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<CreateScooterDto, CreateScooterCommand>()
			.ForMember(scooterCommand => scooterCommand.ScooterName, opt => opt.MapFrom(scooterDto => scooterDto.ScooterName))
			.ForMember(scooterCommand => scooterCommand.DateOfCommissioning, opt => opt.MapFrom(scooterDto => scooterDto.DateOfCommissioning))
			.ForMember(scooterCommand => scooterCommand.Status, opt => opt.MapFrom(scooterDto => scooterDto.Status));
	}
}
