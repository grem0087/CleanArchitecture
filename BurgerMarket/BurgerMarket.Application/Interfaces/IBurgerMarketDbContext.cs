using Microsoft.EntityFrameworkCore;
using BurgerMarket.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace BurgerMarket.Application.Interfaces
{
    public interface IBurgerMarketDbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Burger> Burgers { get; set; }
        DbSet<Drink> Drinks { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
