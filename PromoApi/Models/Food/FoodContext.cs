using Microsoft.EntityFrameworkCore;

namespace PromoApi.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
