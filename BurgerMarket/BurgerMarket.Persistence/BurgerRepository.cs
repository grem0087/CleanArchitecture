using BurgerMarket.Domain.Entities;
using BurgerMarket.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace BurgerMarket.Persistence
{
    public class BurgerRepository : IBurgerRepository
    {
        private DbSet<Burger> _burgers;
        public BurgerRepository(BurgerMarketDbContext marketDataBase)
        {
            _burgers = marketDataBase.Burgers;
        }
        public int AddBurdger(Burger burger)
        {
            throw new System.NotImplementedException();
        }
    }
}