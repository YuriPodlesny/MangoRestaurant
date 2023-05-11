using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface ICartService
    {
        Task<T> GetCartBuyUserIdAsunc<T>(string userId, string token = null);
        Task<T> AddToCartAsunc<T>(CartDto cartDto, string token = null);
        Task<T> UpdateCartAsunc<T>(CartDto cartDto, string token = null);
        Task<T> RemoveFromCartAsunc<T>(int cartId, string token = null);
        Task<T> ApplyCoupon<T>(CartDto cartDto, string token = null);
        Task<T> RemoveCoupon<T>(string userId, string token = null);
        Task<T> Checkout<T>(CartHeaderDto cartHeaderDto, string token = null);
    }
}
