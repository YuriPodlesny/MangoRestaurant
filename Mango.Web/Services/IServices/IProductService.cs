﻿using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsunc<T>();
        Task<T> GetProductByIdAsunc<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);
        Task<T> DeleteProductAsync<T>(int id);

    }
}
