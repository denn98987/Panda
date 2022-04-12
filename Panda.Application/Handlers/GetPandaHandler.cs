using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Repositories;
using MediatR;
using Panda.Application.Commands;
using Panda.Application.Mappers;
using Panda.Application.Responses;

namespace Panda.Application.Handlers;

public class GetPandaHandler : IRequestHandler<GetPandaCommand, PandaResponse>
{
    private readonly IPandaRepository _pandaRepository;
    public GetPandaHandler(IPandaRepository pandaRepository)
    {
        _pandaRepository = pandaRepository;
    }
    
    public async Task<PandaResponse> Handle(GetPandaCommand request, CancellationToken cancellationToken)
    {
        var pandaEntity = _pandaRepository.GetPandasByName(request.PandaName);
        if (pandaEntity != null) 
            throw new ArgumentException();

        return PandaMapper.Mapper.Map<PandaResponse>(pandaEntity);
    }
}