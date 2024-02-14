using Microsoft.EntityFrameworkCore;
using RideFox.Application.Feature.Scooters.Commands.CreateScooter;
using RideFox.Domain.Statuses;
using Scooters.Tests.Common;

namespace Scooters.Tests.Scooters.Commands;
public class CreateScooterCommandHandlerTests : TestCommandBase
{
	[Fact]
	public async Task CreateScooterCommandHandler_Success()
	{
		// Arrange
		var handler = new CreateScooterCommandHandler(_context);
		string scooterName = "Scooter_1";
		ScooterStatus status = ScooterStatus.Rented;
		var dateOfCommissioning = DateTime.Parse("10.10.2010");

		// Act
		Guid scooterId = await handler.Handle(
			new CreateScooterCommand()
			{
				UserId = ScooterContextFactory.GuidUserA,
				Name = scooterName,
				Status = status,
				DateOfCommissioning = dateOfCommissioning
			}, CancellationToken.None);

		// Assert
		Assert.NotNull(await _context.Scooters
			.SingleOrDefaultAsync(s => s.Id == scooterId
			&& s.Name == scooterName
			&& s.Status == status
			&& s.DateOfCommissioning == dateOfCommissioning));
	}
}
