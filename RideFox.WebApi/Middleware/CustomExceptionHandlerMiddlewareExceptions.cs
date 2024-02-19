namespace RideFox.WebApi.Middleware;

public static class CustomExceptionHandlerMiddlewareExceptions
{
	public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
	{
		return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
	}
}
