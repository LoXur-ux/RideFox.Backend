using Microsoft.EntityFrameworkCore;
using RideFox.Domain;
using Path = RideFox.Domain.Path;

namespace RideFox.Application.Interfaces;

public interface IRideFoxDbContext
{
	DbSet<Address> Addresses { get; set; }
	DbSet<Client> Clients { get; set; }
	DbSet<Coordinate> Coordinates { get; set; }
	DbSet<Parking> Parkings { get; set; }
	DbSet<Path> Paths { get; set; }
	DbSet<Payment> Payment { get; set; }
	DbSet<Penalty> Penalty { get; set; }
	DbSet<Rent> Rents { get; set; }
	DbSet<Scooter> Scooters { get; set; }
	DbSet<Service> Services { get; set; }
	DbSet<Staff> Staffs { get; set; }

	Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
