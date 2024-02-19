using FluentValidation;

namespace RideFox.Application.Feature.Scooters.Queries.GetScooter;

public class GetScooterQueryValidator : AbstractValidator<GetScooterQuery>
{
	public GetScooterQueryValidator()
	{
		RuleFor(getScooterQuery => getScooterQuery.Id).NotEmpty().NotEqual(Guid.Empty);
	}
}
