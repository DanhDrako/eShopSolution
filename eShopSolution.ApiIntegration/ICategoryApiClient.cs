using eShopSolution.ViewModels.Catalog.Categories;

namespace eShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
        Task<CategoryVm> GetById(string languageId, int id);


    }
}
