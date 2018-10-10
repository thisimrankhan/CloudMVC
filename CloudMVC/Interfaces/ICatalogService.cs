using Microsoft.AspNetCore.Mvc.Rendering;
using CloudMVC.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudMVC.Web.Services
{
    public interface ICatalogService
    {
        Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
