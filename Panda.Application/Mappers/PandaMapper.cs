using System;
using AutoMapper;

namespace Panda.Application.Mappers;

public class PandaMapper
{
    private static readonly Lazy<IMapper> Lazy = new(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.ShouldMapProperty = propInfo => propInfo.GetMethod != null &&
                                                (propInfo.GetMethod.IsPublic || propInfo.GetMethod.IsAssembly);
            cfg.AddProfile<PandaMappingProfile>();
        });
        var mapper = config.CreateMapper();
        return mapper;
    });

    public static IMapper Mapper => Lazy.Value;
}