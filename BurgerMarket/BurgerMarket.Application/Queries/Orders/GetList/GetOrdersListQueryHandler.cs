using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BurgerMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BurgerMarket.Application.Queries.Orders.GetList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, OrdersListViewModel>
    {
        private readonly IBurgerMarketDbContext _context;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(IBurgerMarketDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrdersListViewModel> Handle(GetOrdersListQuery query, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.Where(x => x.CustomerId == query.CustomerId).FirstAsync(cancellationToken);
            return _mapper.Map<OrdersListViewModel>(order);
        }
    }
}
