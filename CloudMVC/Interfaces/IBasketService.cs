using CloudMVC.Web.ViewModels;
using System.Threading.Tasks;

namespace CloudMVC.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
