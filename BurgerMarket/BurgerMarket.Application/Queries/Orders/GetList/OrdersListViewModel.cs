using System.Collections.Generic;

namespace BurgerMarket.Application.Queries.Orders.GetList
{
    public class OrdersListViewModel
    {
        public IList<BurgerLookupModel> CustomerId { get; set; }
    }
}
