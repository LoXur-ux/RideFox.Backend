using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Scooters.Queries.GetScootersList;

public class GetScooterListQueryHandler : IRequestHandler<GetScooterListQuery, ScooterListVm>
{
	private readonly IRideFoxDbContext _dbContext;
	private readonly IMapper _mapper;

	public GetScooterListQueryHandler(IRideFoxDbContext dbContext, IMapper mapper)
	{
		_dbContext = dbContext;
		_mapper = mapper;
	}

	public async Task<ScooterListVm> Handle(GetScooterListQuery request, CancellationToken cancellationToken)
	{
		IList<ScooterVm> scooters = await _dbContext.Scooters
			.ProjectTo<ScooterVm>(_mapper.ConfigurationProvider)
			.ToListAsync(cancellationToken)
			?? throw new NotFoundEntity(nameof(Scooter));

		return new ScooterListVm() { ScootersVm = scooters };
	}
}
