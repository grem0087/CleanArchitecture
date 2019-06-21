using BurgerMarket.Application.Interfaces;
using BurgerMarket.Application.Notifications.Models;
using System.Threading.Tasks;

namespace BurgerMarket.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
