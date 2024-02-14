using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Interfaces;
using RideFox.Domain;

namespace RideFox.Application.Feature.Addresses.Queries.GetAddress;
public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, AddressVm>
{
	private IRideFoxDbContext _context;
	private IMapper _mapper;

	public GetAddressQueryHandler(IRideFoxDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<AddressVm> Handle(GetAddressQuery request, CancellationToken cancellationToken)
	{
		Address address = await _context.Addresses.FirstOrDefaultAsync(a => a.ToString() == request.FullAddress, cancellationToken)
			?? throw new NotFoundEntity(nameof(Address), request.FullAddress);

		return _mapper.Map<AddressVm>(address);
	}
}
