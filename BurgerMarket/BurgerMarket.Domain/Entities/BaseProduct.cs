using System.Collections.Generic;

namespace BurgerMarket.Domain.Entities
{
    public class BaseProduct
    {
        public int Id { get; private set; }
        public ICollection<OrderProduct> Orders { get; set; }
    }
}