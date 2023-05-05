using Mango.Servrces.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Servrces.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
