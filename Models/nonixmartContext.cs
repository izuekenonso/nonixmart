using Microsoft.EntityFrameworkCore;
using nonixmart.Models;

namespace nonixmart.Data
{
    public class nonixmartContext : DbContext
    {
        public nonixmartContext (DbContextOptions<nonixmartContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}