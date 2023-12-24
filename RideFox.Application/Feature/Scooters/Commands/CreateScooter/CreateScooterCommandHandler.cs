using MediatR;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Scooters.Commands.CreateScooter;

/// <summary>
/// Класс выполнения команды
/// Для реализации интерфейса требуется указать: тип запроса (CreateScooterCommand) и тип ответа (Guid)
/// </summary>
public class CreateScooterCommandHandler : IRequestHandler<CreateScooterCommand, Guid>
{
	private readonly IRideFoxDbContext _dbContext; 

	public CreateScooterCommandHandler(IRideFoxDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<Guid> Handle(CreateScooterCommand request, CancellationToken cancellationToken)
	{
		var scooter = new Scooter
		{
			Id = Guid.NewGuid(),
			ScooterName = request.ScooterName,
			DateOfCommissioning = request.DateOfCommissioning,
			Status = request.Status,
			Rents = null,
			Services = null
		};

		await _dbContext.Scooters.AddAsync(scooter, cancellationToken);
		await _dbContext.SaveChangesAsync(cancellationToken);

		return scooter.Id;
	}
}
