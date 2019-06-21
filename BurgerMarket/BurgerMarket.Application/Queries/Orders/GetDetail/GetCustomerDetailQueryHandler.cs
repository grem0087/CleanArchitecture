using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Exceptions;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Domain.Entities;
using MediatR;

namespace BurgerMarket.Application.Queries.Orders.GetDetail
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailModel>
    {
        private readonly IBurgerMarketDbContext _context;
        private readonly IMapper _mapper;
        
        public GetCustomerDetailQueryHandler(IBurgerMarketDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrderDetailModel> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.OrderId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.OrderId);
            }

            return _mapper.Map<OrderDetailModel>(entity);
        }
    }
}
