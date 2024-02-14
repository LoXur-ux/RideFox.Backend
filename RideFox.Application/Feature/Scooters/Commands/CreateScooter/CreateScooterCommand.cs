using MediatR;
using RideFox.Domain.Statuses;

namespace RideFox.Application.Feature.Scooters.Commands.CreateScooter;

/// <summary>
/// Класс, определяющий возвращаемый ответ (Guid) и поля, которые необходимы для выполнения команды
/// </summary>
public class CreateScooterCommand : IRequest<Guid>
{
	public Guid UserId { get; set; }
	public string Name { get; set; }
	public DateTime DateOfCommissioning { get; set; }
	public ScooterStatus Status { get; set; }
}
