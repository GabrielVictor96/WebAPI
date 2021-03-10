using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Contrato> Contrato { get; set; }
    }
}
