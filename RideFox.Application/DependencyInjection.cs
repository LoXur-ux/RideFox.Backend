using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

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
		return services;
	}
}
