using System.Collections;
using BurgerMarket.Domain.Entities;

namespace BurgerMarket.Domain.Services
{
    public interface IOrderRepository
    {
        int Add(Order order);
        Order GetById(int id);
        void Delete(int id);
        ICollection GetList(int customerId);

        void SaveAll();
    }
}