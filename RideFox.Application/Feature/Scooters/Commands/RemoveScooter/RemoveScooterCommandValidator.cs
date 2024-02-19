using FluentValidation;

namespace RideFox.Application.Feature.Scooters.Commands.RemoveScooter;

internal class RemoveScooterCommandValidator : AbstractValidator<RemoveScooterCommand>
{
	public RemoveScooterCommandValidator()
	{
		RuleFor(removeScooterCommand => removeScooterCommand.UserId).NotEmpty().NotEqual(Guid.Empty);
		RuleFor(removeScooterCommand => removeScooterCommand.Id).NotEmpty().NotEqual(Guid.Empty);
	}
}
