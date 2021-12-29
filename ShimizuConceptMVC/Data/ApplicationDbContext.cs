using Microsoft.EntityFrameworkCore;
using ShimizuConceptMVC.Models;

namespace ShimizuConceptMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ItemModel> Items { get; set; }
    }
}
