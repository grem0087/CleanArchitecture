using System.Threading;
using System.Threading.Tasks;
using BurgerMarket.Application.Exceptions;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Domain.Entities;
using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Delete
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        //TODO: try to show repository
        private readonly IBurgerMarketDbContext _context;

        public DeleteOrderCommandHandler(IBurgerMarketDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.OrderId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.OrderId);
            }

            _context.Customers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
