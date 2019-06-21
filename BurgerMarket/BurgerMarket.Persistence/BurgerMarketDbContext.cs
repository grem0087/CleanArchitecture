using Microsoft.EntityFrameworkCore;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Domain.Entities;
using BurgerMarket.Persistence.Configurations;

namespace BurgerMarket.Persistence
{
    public class BurgerMarketDbContext : DbContext, IBurgerMarketDbContext
    {
        public BurgerMarketDbContext(DbContextOptions<BurgerMarketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Всё из сборки
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BurgerMarketDbContext).Assembly);
            
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            
            modelBuilder.Entity<OrderProduct>()
                .HasKey(t => new { t.OrderId, t.ProductId });
            
            modelBuilder.Entity<OrderProduct>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.Products)
                .HasForeignKey(pt => pt.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(pt => pt.Product)
                .WithMany(t => t.Orders)
                .HasForeignKey(pt => pt.OrderId);
            
            
        }
    }
}
