using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Delete
{
    public class DeleteOrderCommand : IRequest
    {
        public int? OrderId { get; set; }
    }
}
