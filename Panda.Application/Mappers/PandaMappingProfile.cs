using AutoMapper;
using Panda.Application.Commands;
using Panda.Application.Responses;

namespace Panda.Application.Mappers;

public class PandaMappingProfile: Profile
{
    public PandaMappingProfile() {
        CreateMap<Core.Entities.Panda, PandaResponse>().ReverseMap();
        CreateMap<Core.Entities.Panda, CreatePandaCommand>().ReverseMap();
    }
}