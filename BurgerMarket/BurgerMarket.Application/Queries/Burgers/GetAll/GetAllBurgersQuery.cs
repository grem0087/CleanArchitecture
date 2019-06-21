using MediatR;

namespace BurgerMarket.Application.Queries.Burgers.GetAll
{
    public class GetAllBurgersQuery : IRequest<BurgersListViewModel>
    {
    }
}
