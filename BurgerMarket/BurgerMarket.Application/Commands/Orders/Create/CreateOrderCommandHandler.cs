using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Domain.Entities;
using BurgerMarket.Domain.Services;
using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        
        public CreateOrderCommandHandler( IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var orderEntity = _mapper.Map<Order>(request);

            _orderRepository.Add(orderEntity);

            _orderRepository.SaveAll();

            return orderEntity.Id;
        }
    }
}