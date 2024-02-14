using MediatR;
using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Scooters.Commands.UpdateScooter;
public class UpdateScooterCommandHandler : IRequestHandler<UpdateScooterCommand, Guid>
{
	private readonly IRideFoxDbContext _dbContext;

	public UpdateScooterCommandHandler(IRideFoxDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<Guid> Handle(UpdateScooterCommand request, CancellationToken cancellationToken)
	{
		Scooter? scooter = await _dbContext.Scooters.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken)
			?? throw new NotFoundEntity(nameof(Scooter), request.Id);

		scooter.Name = request.Name;
		scooter.Status = request.Status;
		scooter.Services = request.Services;
		scooter.Rents = request.Rents;

		await _dbContext.Scooters.AddAsync(scooter, cancellationToken);
		await _dbContext.SaveChangesAsync(cancellationToken);

		return scooter.Id;
	}
}
