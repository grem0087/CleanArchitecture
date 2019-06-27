using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Application.Notifications.Models;
using BurgerMarket.Domain.Entities;
using BurgerMarket.Domain.Services;
using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
     {
         private INotificationService _notificationService;
         private readonly IOrderRepository _orderRepository;
         private readonly IMapper _mapper;
         
         public CreateOrderCommandHandler( IOrderRepository orderRepository, IMapper mapper, INotificationService notificationService)
         {
             _orderRepository = orderRepository;
             _mapper = mapper;
             _notificationService = notificationService;
         }
 
         public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
         {
             var orderEntity = _mapper.Map<Order>(request);
 
             _orderRepository.Add(orderEntity);
 
             _orderRepository.SaveAll();
             await _notificationService.SendAsync(new Message
                 {To = "MyLittleFriend", Body = $"OrderCreated with Id {orderEntity.Id}"});
             
             return orderEntity.Id;
         }
     }
 }