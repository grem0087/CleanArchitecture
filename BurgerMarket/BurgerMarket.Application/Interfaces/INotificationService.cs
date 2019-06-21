using BurgerMarket.Application.Notifications.Models;
using System.Threading.Tasks;

namespace BurgerMarket.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
