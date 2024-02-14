using System.Reflection;
using RideFox.Application;
using RideFox.Application.Common.Mapping;
using RideFox.Application.Interfaces;
using RideFox.Persistence;

namespace RideFox.WebApi;

/// <summary>
/// �������� ����� ��������� � ������� Main
/// </summary>
public class Program
{
	/// <summary>
	/// ����� ����� � ����������
	/// </summary>
	/// <param name="args"></param>
	public static void Main(string[] args)
	{
		WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
		// ����������� ������� AutoMapper
		builder.Services.AddAutoMapper(config =>
		{
			config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
			config.AddProfile(new AssemblyMappingProfile(typeof(IRideFoxDbContext).Assembly));
		});

		builder.Services.AddApplication();
		builder.Services.AddPersistence(builder.Configuration);
		builder.Services.AddControllers();

		// ���������� CORS
		builder.Services.AddCors(option =>
		{
			option.AddPolicy("AllowAll", policy =>
			{
				policy.AllowAnyHeader();
				policy.AllowAnyMethod();
				policy.AllowAnyOrigin();
			});
		});


		// ������ ������ Configure(IApplicationBuilder app, IWebHostEnvironment env)
		WebApplication app = builder.Build();
		using(IServiceScope scope = app.Services.CreateScope())
		{
			IServiceProvider serviceProvider = scope.ServiceProvider;
			try
			{
				RideFoxDbContext context = serviceProvider.GetRequiredService<RideFoxDbContext>();
				DbInitializer.Initialize(context);
			}
			catch(Exception ex) { }
		}

		// ����������� ������������
		app.UseRouting();
		app.UseHttpsRedirection();
		app.UseCors("AllowAll");
		app.MapControllers();

		app.Run();
	}
}
