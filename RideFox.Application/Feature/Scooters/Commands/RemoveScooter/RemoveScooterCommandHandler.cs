using MediatR;
using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Scooters.Commands.RemoveScooter;

internal class RemoveScooterCommandHandler : IRequestHandler<RemoveScooterCommand, Unit>
{
	private readonly IRideFoxDbContext _dbContext;

	public RemoveScooterCommandHandler(IRideFoxDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<Unit> Handle(RemoveScooterCommand request, CancellationToken cancellationToken)
	{
		Scooter scooter = await _dbContext.Scooters.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken)
			?? throw new NotFoundEntity(nameof(Scooter), request.Id);

		_dbContext.Scooters.Remove(scooter);
		await _dbContext.SaveChangesAsync(cancellationToken);

		return Unit.Value;
	}
}
