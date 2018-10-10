using CloudMVC.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace CloudMVC.ApplicationCore.Interfaces
{

    public interface IOrderRepository : IRepository<Order>, IAsyncRepository<Order>
    {
        Order GetByIdWithItems(int id);
        Task<Order> GetByIdWithItemsAsync(int id);
    }
}
