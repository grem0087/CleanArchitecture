using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Interfaces;
using MediatR;

namespace BurgerMarket.Application.Queries.Burgers.Get
{
    public class GetBurgerQueryHandler : IRequestHandler<GetBurgerQuery, BurgerViewModel>
    {
        private readonly IBurgerMarketDbContext _context;
        private readonly IMapper _mapper;

        public GetBurgerQueryHandler(IBurgerMarketDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BurgerViewModel> Handle(GetBurgerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
