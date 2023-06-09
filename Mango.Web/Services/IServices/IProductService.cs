﻿using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsunc<T>(string token);
        Task<T> GetProductByIdAsunc<T>(int id, string token);
        Task<T> CreateProductAsync<T>(ProductDto productDTO, string token);
        Task<T> UpdateProductAsync<T>(ProductDto productDTO, string token);
        Task<T> DeleteProductAsync<T>(int id, string token);

    }
}
