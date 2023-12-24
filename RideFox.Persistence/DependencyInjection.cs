using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RideFox.Application.Interfaces;

namespace RideFox.Persistence;
public static class DependencyInjection
{
	/// <summary>
	/// Регистрация сервиса Контекста БД
	/// </summary>
	/// <param name="services"></param>
	/// <param name="configuration">Файл конфигурации, из которого берется строка подключения</param>
	/// <returns></returns>
	public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
	{
		string? connectionString = configuration["DbConnectionString"];
		services.AddDbContext<RideFoxDbContext>(options => options.UseNpgsql(connectionString));
		services.AddScoped<IRideFoxDbContext>(provider => provider.GetService<RideFoxDbContext>());

		return services;
	}
}
