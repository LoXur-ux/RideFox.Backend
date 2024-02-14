using Microsoft.EntityFrameworkCore;
using RideFox.Application.Common.Exceptions;
using RideFox.Application.Feature.Scooters.Commands.RemoveScooter;
using Scooters.Tests.Common;

namespace Scooters.Tests.Scooters.Commands;
public class RemoveScooterCommandHandlerTests : TestCommandBase
{
	[Fact]
	public async Task RemoveScooterCommandHandler_Success()
	{
		// Arrange
		var handler = new RemoveScooterCommandHandler(_context);

		// Act 
		await handler.Handle(new RemoveScooterCommand()
		{
			Id = ScooterContextFactory.GuidAToDel
		}, CancellationToken.None);
		
		// Assert
		Assert.NotNull(_context.Scooters
			.SingleOrDefaultAsync(s => s.Id == ScooterContextFactory.GuidAToDel));
	}

	[Fact]
	public async Task RemoveScooterCommandHandler_FailScooterId()
	{
		// Arrange
		var handler = new RemoveScooterCommandHandler(_context);

		// Act
		// Assert
		await Assert.ThrowsAsync<NotFoundEntity>(async () => await handler.Handle(
			new RemoveScooterCommand()
			{
				UserId = ScooterContextFactory.GuidUserA,
				Id = Guid.NewGuid()
			}, CancellationToken.None));
	}

	[Fact]
	public async Task RemoveScooterCommandHandler_FailUserId()
	{
		// Arrange
		var handler = new RemoveScooterCommandHandler(_context);

		// Act
		// Assert
		await Assert.ThrowsAsync<NotFoundEntity>(async () => await handler.Handle(
			new RemoveScooterCommand()
			{
				UserId = Guid.NewGuid(),
				Id = ScooterContextFactory.GuidBToDel
			}, CancellationToken.None));
	}
}
