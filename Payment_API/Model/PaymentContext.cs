using Microsoft.EntityFrameworkCore;


namespace Payment_API.Model
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }

        public DbSet<Devise> Devises { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
