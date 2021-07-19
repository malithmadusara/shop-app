using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDto);
        Task<T> UpdateProductAsync<T>(ProductDTO productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
