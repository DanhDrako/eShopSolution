using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Languages;
using eShopSolution.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
namespace eShopSolution.ApiIntegration
{
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        public SlideApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<SlideVm>> GetAll()
        {
            return await GetListAsync<SlideVm>("/api/slides");
        }
    }
}
