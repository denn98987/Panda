using System;

namespace Panda.Application.Responses;

public class PandaResponse
{
    public int PandaId
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    public DateTime DateBirth
    {
        get;
        set;
    }

    public int ParentId
    {
        get;
        set;
    }
}