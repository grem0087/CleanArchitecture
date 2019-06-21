using System.Threading;
using System.Threading.Tasks;
using BurgerMarket.Application.Commands.Orders.Create;
using MediatR;

namespace BurgerMarket.Application.Commands.Burgers
{
    public class CreateBurgerCommandHandler: IRequestHandler<CreateBurgerCommand, int>
    {
        public Task<int> Handle(CreateBurgerCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}