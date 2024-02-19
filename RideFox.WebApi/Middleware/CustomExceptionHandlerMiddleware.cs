using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using RideFox.Application.Common.Exceptions;

namespace RideFox.WebApi.Middleware;

public class CustomExceptionHandlerMiddleware
{
	private readonly RequestDelegate _next;

	public CustomExceptionHandlerMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task Invoke(HttpContext context)
	{
		try
		{
			await _next(context);
		}
		catch(Exception ex)
		{
			await HandleExceptionAsync(context, ex);
		}
	}

	private Task HandleExceptionAsync(HttpContext context, Exception ex)
	{
		HttpStatusCode code = HttpStatusCode.InternalServerError;
		string result = string.Empty;
		switch(ex)
		{
			case ValidationException validationException:
				code = HttpStatusCode.BadRequest;
				result = JsonSerializer.Serialize(validationException.Data);
				break;
			case NotFoundEntity notFoundEntity:
				code = HttpStatusCode.NotFound;
				break;
		}

		context.Response.ContentType = "application/json";
		context.Response.StatusCode = (int)code;
		if(result == string.Empty)
			result = JsonSerializer.Serialize(new { errpr = ex.Message });

		return context.Response.WriteAsync(result);
	}
}
