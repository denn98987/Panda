using System;
using MediatR;
using Panda.Application.Responses;

namespace Panda.Application.Commands;

public class GetPandaCommand : IRequest<PandaResponse>
{
    public string PandaName { get; set; }
}