using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RideFox.Application.Feature.Scooters.Commands.CreateScooter;
using RideFox.Application.Feature.Scooters.Commands.RemoveScooter;
using RideFox.Application.Feature.Scooters.Queries.GetScooter;
using RideFox.Application.Feature.Scooters.Queries.GetScooters;
using RideFox.WebApi.Models;

namespace RideFox.WebApi.Controllers;

[Route("api/[controller]")]
public class ScooterController : BaseController
{
	private readonly IMapper _mapper;

	public ScooterController(IMapper mapper)
	{
		_mapper = mapper;
	}

	[HttpGet]
	public async Task<ActionResult<ScooterListVm>> GetAll()
	{
		var query = new GetScooterListQuery();
		ScooterListVm vm = await Mediator.Send(query);

		return Ok(vm);
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<ScooterVm>> Get(Guid id)
	{
		var query = new GetScooterQuery { Id = id };
		ScooterVm vm = await Mediator.Send(query);

		return Ok(vm);
	}

	[HttpPost]
	public async Task<ActionResult<ScooterVm>> Create([FromBody] CreateScooterDto scooterDto)
	{
		CreateScooterCommand command = _mapper.Map<CreateScooterCommand>(scooterDto);
		Guid vm = await Mediator.Send(command);

		return Ok(vm);
	}

	[HttpPut]
	public async Task<ActionResult<ScooterVm>> Update([FromBody] UpdateScooterDto createScooterDto)
	{
		CreateScooterCommand command = _mapper.Map<CreateScooterCommand>(createScooterDto);
		Guid vm = await Mediator.Send(command);

		return Ok(vm);
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> Remove(Guid id)
	{
		var command = new RemoveScooterCommand { Id = id };
		await Mediator.Send(command);

		return NoContent();
	}
}
