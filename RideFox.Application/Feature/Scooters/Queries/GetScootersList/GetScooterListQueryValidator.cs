using FluentValidation;

namespace RideFox.Application.Feature.Scooters.Queries.GetScootersList;

public class GetScooterListQueryValidator : AbstractValidator<GetScooterListQuery>
{
	public GetScooterListQueryValidator()
	{
		//RuleFor(getScooterListQuery => getScooterListQuery);
	}
}
