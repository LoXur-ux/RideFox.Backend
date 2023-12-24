using System.Security.Claims;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RideFox.WebApi.Controllers;

/// <summary>
/// Базовый класс контроллера, от которого наследуются все контроллеры
/// </summary>
[ApiController]
[Route("api/[controller]/[action]")]
public abstract class BaseController : ControllerBase
{
	// Медиатор нужен для формирования команд при формировании запросов
	private IMediator _mediator;
	protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
	internal Guid UserId => !User.Identity.IsAuthenticated
		? Guid.Empty
		: Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
}
