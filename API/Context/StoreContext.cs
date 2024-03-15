using API.Enities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
