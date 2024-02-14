using AutoMapper;
using RideFox.Application.Common.Mapping;
using RideFox.Application.Feature.Scooters.Commands.CreateScooter;
using RideFox.Domain.Statuses;

namespace RideFox.WebApi.Models;

/// <summary>
/// Класс-модель, который определяет маппинг приходящего запроса в запрос для БД
/// </summary>
public class CreateScooterDto : IMapWith<CreateScooterCommand>
{
	public string Name { get; set; }
	public DateTime DateOfCommissioning {  get; set; }
	public ScooterStatus Status { get; set; }

	/// <summary>
	/// Маппинг
	/// </summary>
	/// <param name="profile"></param>
	public void Mapping(Profile profile)
	{
		profile.CreateMap<CreateScooterDto, CreateScooterCommand>()
			.ForMember(scooterCommand => scooterCommand.Name, opt => opt.MapFrom(scooterDto => scooterDto.Name))
			.ForMember(scooterCommand => scooterCommand.DateOfCommissioning, opt => opt.MapFrom(scooterDto => scooterDto.DateOfCommissioning))
			.ForMember(scooterCommand => scooterCommand.Status, opt => opt.MapFrom(scooterDto => scooterDto.Status));
	}
}
