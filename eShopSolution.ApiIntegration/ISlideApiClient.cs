using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Utilities.Slides;

namespace eShopSolution.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
