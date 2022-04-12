using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class PandaContext: DbContext
    {
        public PandaContext(DbContextOptions<PandaContext> options): base(options){ }

        public DbSet<Panda> Pandas { get; set; }
    }
}