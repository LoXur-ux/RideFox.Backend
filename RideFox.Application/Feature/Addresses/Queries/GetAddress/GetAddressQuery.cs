using MediatR;

namespace RideFox.Application.Feature.Addresses.Queries.GetAddress;

public class GetAddressQuery : IRequest<AddressVm>
{
	public string FullAddress {  get; set; }
}
