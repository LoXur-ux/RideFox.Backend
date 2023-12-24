using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RideFox.Persistence;
public class DbInitializer
{
	/// <summary>
	/// Инициализация контекста БД
	/// </summary>
	/// <param name="context">Контекст БД (Dependency Injection)</param>
	public static void Initialize(RideFoxDbContext context)
	{
		context.Database.Migrate();
	}
}
