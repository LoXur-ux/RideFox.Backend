using FluentValidation;

namespace RideFox.Application.Feature.Scooters.Commands.UpdateScooter;

public class UpdateScooterCommandValidator : AbstractValidator<UpdateScooterCommand>
{
	public UpdateScooterCommandValidator()
	{
		RuleFor(updateScooterCommand => updateScooterCommand.Id).NotEmpty().NotEqual(Guid.Empty);
	}
}
