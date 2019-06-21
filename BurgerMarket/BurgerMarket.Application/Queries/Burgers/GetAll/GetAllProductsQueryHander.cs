using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Interfaces;
using MediatR;

namespace BurgerMarket.Application.Queries.Burgers.GetAll
{
    public class GetAllBurgersQueryHandler : IRequestHandler<GetAllBurgersQuery, BurgersListViewModel>
    {
        private readonly IBurgerMarketDbContext _context;
        private readonly IMapper _mapper;

        public GetAllBurgersQueryHandler(IBurgerMarketDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BurgersListViewModel> Handle(GetAllBurgersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
