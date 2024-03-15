using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using Application.Users.GetUsers;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    //Sender de mediatr
    private readonly ISender? _sender;

    public UserController(ISender? sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers(
        CancellationToken cancellationToken
    )
    {
        var query = new GetUsersQuery();
        var actionResult = await _sender!.Send(query, cancellationToken);
        return actionResult.Success ? Ok(actionResult) : NotFound();
    }
}
