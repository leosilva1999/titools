using Microsoft.EntityFrameworkCore;
using ApiTiTools.Models;
namespace ApiTiTools.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Caller>? Callers { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Call>? Calls { get; set; }
    }
}
