using Microsoft.EntityFrameworkCore;
using PromoApi.Models;

namespace PromoApi.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<PromoApi.Models.Food> Food { get; set; }
    }
}
