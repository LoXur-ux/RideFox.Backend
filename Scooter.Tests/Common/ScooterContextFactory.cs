using Microsoft.EntityFrameworkCore;
using RideFox.Domain;
using RideFox.Persistence;

namespace Scooters.Tests.Common;
internal class ScooterContextFactory
{
	public static Guid GuidUserA { get; set; } = new Guid();
	public static Guid GuidUserB { get; set; } = new Guid();

	public static Guid GuidAToDel { get; set; } = Guid.Parse("95C90721-0C93-4248-8066-F6E76078A8BD");
	public static Guid GuidBToDel { get; set; } = new Guid();

	public static RideFoxDbContext Create()
	{
		DbContextOptions<RideFoxDbContext> options = new DbContextOptionsBuilder<RideFoxDbContext>()
			.UseInMemoryDatabase(Guid.NewGuid().ToString())
			.Options;
		var context = new RideFoxDbContext(options);
		context.Database.EnsureCreated();
		context.Scooters.AddRange(
			new Scooter()
			{
				Id = Guid.Parse("A5D0A59B-9C43-4389-B23C-B40801FD32FF"),
				Name = "Scooter_1",
				DateOfCommissioning = DateTime.Now,
				Status = RideFox.Domain.Statuses.ScooterStatus.Rented,
				Coordinate = new Coordinate()
				{
					Id = Guid.Parse("EBDC2D4D-85ED-4391-90DC-DD7D15E7E8C2"),
					Latitude = 66,
					Longitude = 99,
				}
			},
			new Scooter()
			{
				Id = Guid.Parse("95C90721-0C93-4248-8066-F6E76078A8BD"),
				Name = "Scooter_2",
				DateOfCommissioning = DateTime.Now,
				Status = RideFox.Domain.Statuses.ScooterStatus.Rented,
				Coordinate = new Coordinate()
				{
					Id = Guid.Parse("ED0C05F9-C0ED-4614-9C73-0B7889BE7C3D"),
					Latitude = 166,
					Longitude = 199,
				}
			},
			new Scooter()
			{
				Id = Guid.Parse("9E06A645-77C8-4CD3-8720-1973920A0ED2"),
				Name = "Scooter_3",
				DateOfCommissioning = DateTime.Now,
				Status = RideFox.Domain.Statuses.ScooterStatus.Rented,
				Coordinate = new Coordinate()
				{
					Id = Guid.Parse("D23053AA-8AAD-4CFB-90AA-2EF5C711B204"),
					Latitude = 166.666,
					Longitude = 199.666,
				}
			});

		context.SaveChanges();
		return context;
	}

	public static void Destroy(RideFoxDbContext context)
	{
		context.Database.EnsureDeleted();
		context.Dispose();
	}
}
