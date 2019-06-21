using BurgerMarket.Domain.Entities;

namespace BurgerMarket.Domain.Services
{
    public interface IBurgerRepository
    {
        int AddBurdger(Burger burger);
    }
}