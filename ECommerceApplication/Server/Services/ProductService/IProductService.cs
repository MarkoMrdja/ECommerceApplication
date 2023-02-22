using Microsoft.AspNetCore.Mvc;

namespace ECommerceApplication.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
