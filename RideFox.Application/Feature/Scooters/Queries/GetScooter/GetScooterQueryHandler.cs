using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Feature.Scooters.Queries.GetScooters;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Scooters.Queries.GetScooter;
public class GetScooterQueryHandler : IRequestHandler<GetScooterQuery, ScooterVm>
{
	private IRideFoxDbContext _context;
	private IMapper _mapper;

	public GetScooterQueryHandler(IRideFoxDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<ScooterVm> Handle(GetScooterQuery request, CancellationToken cancellationToken)
	{
		Scooter scooter = await _context.Scooters.FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken)
			?? throw new NotFoundEntity(nameof(Scooter), request.Id);

		return _mapper.Map<ScooterVm>(scooter);
	}
}
