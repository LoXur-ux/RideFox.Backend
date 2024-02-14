using RideFox.Domain.Statuses;
using RideFox.Domain;
using RideFox.Application.Common.Mapping;
using RideFox.Application.Feature.Scooters.Commands.UpdateScooter;
using AutoMapper;

namespace RideFox.WebApi.Models;

public class UpdateScooterDto : IMapWith<UpdateScooterCommand>
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public ScooterStatus Status { get; set; }
	public ICollection<Rent> Rents { get; set; }
	public ICollection<Service> Services { get; set; }

	/// <summary>
	/// Маппер
	/// </summary>
	public void Mapping(Profile profile)
	{
		profile.CreateMap<UpdateScooterDto, UpdateScooterCommand>()
			.ForMember(scooterCommand => scooterCommand.Id, opt => opt.MapFrom(scooterDto => scooterDto.Id))
			.ForMember(scooterCommand => scooterCommand.Name, opt => opt.MapFrom(scooterDto => scooterDto.Name))
			.ForMember(scooterCommand => scooterCommand.Status, opt => opt.MapFrom(scooterDto => scooterDto.Status))
			.ForMember(scooterCommand => scooterCommand.Rents, opt => opt.MapFrom(scooterDto => scooterDto.Rents))
			.ForMember(scooterCommand => scooterCommand.Services, opt => opt.MapFrom(scooterDto => scooterDto.Services));
	}
}
