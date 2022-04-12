using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Repositories;
using MediatR;
using Panda.Application.Commands;
using Panda.Application.Mappers;
using Panda.Application.Responses;

namespace Panda.Application.Handlers;

public class CreatePandaHandler : IRequestHandler<CreatePandaCommand, PandaResponse>
{
    private readonly IPandaRepository _pandaRepository;

    public CreatePandaHandler(IPandaRepository pandaRepository)
    {
        _pandaRepository = pandaRepository;
    }

    public async Task<PandaResponse> Handle(CreatePandaCommand request, CancellationToken cancellationToken)
    {
        var pandaEntity = PandaMapper.Mapper.Map<Core.Entities.Panda>(request);
        if (pandaEntity is null) 
            throw new ApplicationException("Mapper is null");
        var panda = await _pandaRepository.AddAsync(pandaEntity);
        var pandasResponse = PandaMapper.Mapper.Map<PandaResponse>(panda);

        return pandasResponse;
    }
}