using Microsoft.EntityFrameworkCore;
using FirstCoreProject.Models;
namespace FirstCoreProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Category> categories { get; set; } 
    }
}
