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
            //Get all configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BurgerMarketDbContext).Assembly);
            
        }
    }
}
