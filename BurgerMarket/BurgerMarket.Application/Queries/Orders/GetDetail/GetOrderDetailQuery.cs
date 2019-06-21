using MediatR;

namespace BurgerMarket.Application.Queries.Orders.GetDetail
{
    public class GetOrderDetailQuery : IRequest<OrderDetailModel>
    {
        public int? OrderId { get; set; }
    }
}
