using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Panda.Application.Commands;
using Panda.Application.Responses;

namespace panda.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
[Route("api/pandas")]
public class PandaController : ControllerBase
{
    private readonly IMediator _mediator;

    public PandaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<PandaResponse>> CreatePanda([FromBody] CreatePandaCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<PandaResponse>> GetPanda([FromQuery] GetPandaCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}