using System;
using MediatR;
using Panda.Application.Responses;

namespace Panda.Application.Commands;

public class CreatePandaCommand : IRequest<PandaResponse>
{
    public string Name { get; set; }

    public DateTime DateBirth { get; set; }

    public int ParentId { get; set; }
}