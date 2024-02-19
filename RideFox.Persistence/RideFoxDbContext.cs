using Microsoft.EntityFrameworkCore;
using RideFox.Application.Interfaces;
using RideFox.Domain;
using RideFox.Persistence.EntityTypeConfigurations;
using Path = RideFox.Domain.Path;

namespace RideFox.Persistence;

/// <summary>
/// Класс контекста БД
/// </summary>
public class RideFoxDbContext : DbContext, IRideFoxDbContext
{
	#region Fields

	public DbSet<Address> Addresses { get; set; }
	public DbSet<Client> Clients { get; set; }
	public DbSet<Coordinate> Coordinates { get; set; }
	public DbSet<Parking> Parkings { get; set; }
	public DbSet<Path> Paths { get; set; }
	public DbSet<Payment> Payments { get; set; }
	public DbSet<Penalty> Penalties { get; set; }
	public DbSet<Rent> Rents { get; set; }
	public DbSet<Scooter> Scooters { get; set; }
	public DbSet<Service> Services { get; set; }
	public DbSet<Staff> Staffs { get; set; }

	#endregion Fields

	public RideFoxDbContext(DbContextOptions<RideFoxDbContext> options) : base(options) { }

	/// <summary>
	/// Конфигурация при инициализации моделей
	/// </summary>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new AddressConfigurations());
		modelBuilder.ApplyConfiguration(new ClientConfiguration());
		modelBuilder.ApplyConfiguration(new CoordinateConfigurations());
		modelBuilder.ApplyConfiguration(new ParkingConfiguration());
		modelBuilder.ApplyConfiguration(new PathConfiguration());
		modelBuilder.ApplyConfiguration(new PaymentConfiguration());
		modelBuilder.ApplyConfiguration(new PenaltyConfiguration());
		modelBuilder.ApplyConfiguration(new RentConfiguration());
		modelBuilder.ApplyConfiguration(new ScooterConfiguration());
		modelBuilder.ApplyConfiguration(new ServiceConfiguration());
		modelBuilder.ApplyConfiguration(new StaffConfiguration());

		base.OnModelCreating(modelBuilder);
	}
}
