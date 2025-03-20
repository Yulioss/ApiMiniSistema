using ApiMiniSistema.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiMiniSistema
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }
        public DbSet<Productos> Productos { get; set; }
    }
}
