using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RideFox.Application.Common.Behaviors;

namespace RideFox.Application;

/// <summary>
/// Класс внедрения зависимостей
/// </summary>
public static class DependencyInjection
{
	/// <summary>
	/// Регистрация Медиатора
	/// </summary>
	/// <param name="services"></param>
	/// <returns></returns>
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
		return services;
	}
}
