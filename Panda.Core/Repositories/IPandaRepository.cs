using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Repositories
{
    public interface IPandaRepository : IRepository<Panda>
    {
        Task<IEnumerable<Panda>> GetPandasByBirth(DateTime bdate);
    }
}