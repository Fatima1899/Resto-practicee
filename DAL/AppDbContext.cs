using Microsoft.EntityFrameworkCore;
using Resto_practice.Models;

namespace Resto_practice.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Menu> Menu { get; set; }
    }
}
