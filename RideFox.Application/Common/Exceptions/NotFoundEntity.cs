namespace RideFox.Application.Common.Exceptions;

public class NotFoundEntity : Exception
{
	public NotFoundEntity(string name, object key) : base($"Entity \"{name}\" ({key}) not found!")
	{

	}

	public NotFoundEntity(string name) : base($"Entities \"{name}\" not found!")
	{

	}
}
