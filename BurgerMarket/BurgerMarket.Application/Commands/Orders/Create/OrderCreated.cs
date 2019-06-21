using System.Threading;
using System.Threading.Tasks;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Application.Notifications.Models;
using MediatR;

namespace BurgerMarket.Application.Commands.Orders.Create
{
    public class OrderCreated : INotification
    {
        public string CustomerId { get; set; }

        public class CustomerCreatedHandler : INotificationHandler<OrderCreated>
        {
            private readonly INotificationService _notification;

            public CustomerCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(OrderCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
