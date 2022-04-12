using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly PandaContext _pandaContext;

    public Repository(PandaContext pandaContext)
    {
        _pandaContext = pandaContext;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _pandaContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _pandaContext.Set<T>().FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _pandaContext.Set<T>().AddAsync(entity);
        await _pandaContext.SaveChangesAsync();

        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _pandaContext.Set<T>().Remove(entity);
        await _pandaContext.SaveChangesAsync();
    }
}