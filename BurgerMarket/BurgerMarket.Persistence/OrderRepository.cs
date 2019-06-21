using System.Collections;
using BurgerMarket.Domain.Entities;
using BurgerMarket.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace BurgerMarket.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private BurgerMarketDbContext _context;
        private DbSet<Order> _burgers;
        public OrderRepository(BurgerMarketDbContext marketDataBase, BurgerMarketDbContext context)
        {
            _context = context;
            _burgers = marketDataBase.Orders;
        }
        
        public int Add(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection GetList(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }
    }
}