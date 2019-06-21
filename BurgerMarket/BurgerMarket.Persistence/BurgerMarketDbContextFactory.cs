using Microsoft.EntityFrameworkCore;
using BurgerMarket.Persistence.Infrastructure;

namespace BurgerMarket.Persistence
{
    public class BurgerMarketDbContextFactory : DesignTimeDbContextFactoryBase<BurgerMarketDbContext>
    {
        protected override BurgerMarketDbContext CreateNewInstance(DbContextOptions<BurgerMarketDbContext> options)
        {
            return new BurgerMarketDbContext(options);
        }
    }
}
