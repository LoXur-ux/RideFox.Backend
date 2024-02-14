using AutoMapper;
using RideFox.Application.Common.Mapping;
using RideFox.Domain;

namespace RideFox.Application.Feature.Addresses.Queries.GetAddress;

public class AddressVm : IMapWith<Address>
{
	public string Town { get; set; }
	public string Street { get; set; }
	public string Number { get; set; }
	public string Build { get; set; }

	public void Mapping(Profile profile)
	{
		profile.CreateMap<Address, AddressVm>()
			.ForMember(addressVm => addressVm.Town, address => address.MapFrom(address => address.Town))
			.ForMember(addressVm => addressVm.Street, address => address.MapFrom(address => address.Street))
			.ForMember(addressVm => addressVm.Number, address => address.MapFrom(address => address.Number))
			.ForMember(addressVm => addressVm.Build, address => address.MapFrom(address => address.Build));
	}
}
