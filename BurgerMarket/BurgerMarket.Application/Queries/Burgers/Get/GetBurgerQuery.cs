using MediatR;

namespace BurgerMarket.Application.Queries.Burgers.Get
{
    public class GetBurgerQuery : IRequest<BurgerViewModel>
    {
        public int BurgerId { get; set; }
    }
}
