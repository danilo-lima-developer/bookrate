using BookRate.Models;
using Microsoft.EntityFrameworkCore;

namespace BookRate.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
