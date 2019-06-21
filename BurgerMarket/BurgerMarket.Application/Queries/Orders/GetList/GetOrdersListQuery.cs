using MediatR;

namespace BurgerMarket.Application.Queries.Orders.GetList
{
    public class GetOrdersListQuery : IRequest<OrdersListViewModel>
    {
        public int CustomerId { get; set; }
    }
}
