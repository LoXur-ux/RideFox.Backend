using FluentValidation;

namespace RideFox.Application.Feature.Scooters.Commands.CreateScooter;

/// <summary>
/// Класс валидирующий <see cref="CreateScooterCommand"/>
/// </summary>
public class CreateScooterCommandValidator : AbstractValidator<CreateScooterCommand>
{
	/// <summary>
	/// Определение валидации для <see cref="CreateScooterCommand"/>
	/// </summary>
	public CreateScooterCommandValidator()
	{
		RuleFor(createScooterCommand => createScooterCommand.Name).NotEmpty().MaximumLength(120);
		RuleFor(createScooterCommand => createScooterCommand.UserId).NotEqual(Guid.Empty);
	}
}
