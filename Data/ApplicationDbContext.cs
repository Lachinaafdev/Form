using FormRegistro.Models;
using Microsoft.EntityFrameworkCore;

namespace FormRegistro.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
