using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Panda.Application.Commands;
using Panda.Application.Responses;

namespace panda.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class PandaController : ControllerBase
{
    private readonly IMediator _mediator;

    public PandaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("/pandas")]
    public async Task<ActionResult<PandaResponse>> CreatePanda([FromBody] CreatePandaCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}