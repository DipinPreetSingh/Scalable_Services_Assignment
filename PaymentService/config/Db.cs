using Microsoft.EntityFrameworkCore;
using payment_service.models;

namespace payment_service.config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PaymentModel> Payments { get; set; }
    }
}
