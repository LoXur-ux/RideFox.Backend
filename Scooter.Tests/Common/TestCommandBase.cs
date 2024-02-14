using RideFox.Persistence;

namespace Scooters.Tests.Common;
public abstract class TestCommandBase : IDisposable
{
	protected readonly RideFoxDbContext _context;

	public TestCommandBase()
	{
		_context = ScooterContextFactory.Create();
	}

	public void Dispose() => ScooterContextFactory.Destroy(_context);
}
