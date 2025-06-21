using Microsoft.EntityFrameworkCore;
using UsuariosCrud.Models;

namespace UsuariosCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
