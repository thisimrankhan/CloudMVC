using CloudMVC.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace CloudMVC.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
    }
}
