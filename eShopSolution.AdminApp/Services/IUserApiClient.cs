﻿using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<PagedResult<UserVM>>> GetUsersPagings(GetUserPagingRequest request);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);
        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);
        Task<ApiResult<UserVM>> GetById(Guid id);


    }
}
