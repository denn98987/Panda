using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class PandaRepository : Repository<Core.Entities.Panda>, IPandaRepository
{
    public PandaRepository(PandaContext pandaContext) : base(pandaContext)
    {
    }

    public async Task<IEnumerable<Panda>> GetPandasByBirth(DateTime bdate)
    {
        return await _pandaContext.Pandas.Where(panda => panda.DateOfBirth == bdate).ToListAsync();
    }
}