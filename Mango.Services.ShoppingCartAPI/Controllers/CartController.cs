using Azure;
using Mango.Services.ShoppingCartAPI.Models.Dto;
using Mango.Services.ShoppingCartAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ShoppingCartAPI.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly ResponseDto _responseDto;

        public CartController(ICartRepository cartRepository, ResponseDto responseDto)
        {
            _cartRepository = cartRepository;
            _responseDto = responseDto;
        }

        [HttpGet("GetCart/{userId}")]
        public async Task<ActionResult<ResponseDto>> GetCart(string userId)
        {
            try
            {
                CartDto cartDto = await _cartRepository.GetCartByUserId(userId);
                _responseDto.Result = cartDto;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMassages = new List<string>() { ex.Message };
                throw;
            }
            return _responseDto;
        }

        [HttpPost("AddCart")]
        public async Task<ActionResult<ResponseDto>> AddCart(CartDto cartDto)
        {
            try
            {
                CartDto cartDt = await _cartRepository.CreateUpdateCart(cartDto);
                _responseDto.Result = cartDt;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMassages = new List<string>() { ex.Message };
                throw;
            }
            return _responseDto;
        }

        [HttpPost("UpdateCart")]
        public async Task<ActionResult<ResponseDto>> UpdateCart(CartDto cartDto)
        {
            try
            {
                CartDto cartDt = await _cartRepository.CreateUpdateCart(cartDto);
                _responseDto.Result = cartDt;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMassages = new List<string>() { ex.Message };
                throw;
            }
            return _responseDto;
        }

        [HttpPost("RemoveCart")]
        public async Task<ActionResult<ResponseDto>> RemoveCart([FromBody]int cartId)
        {
            try
            {
                bool isSuccess = await _cartRepository.RemoveFromCart(cartId);
                _responseDto.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMassages = new List<string> { ex.Message };
                throw;
            }
            return _responseDto;
        }

        [HttpPost("ClearCart")]
        public async Task<ActionResult<ResponseDto>> ClearCart([FromBody]string userId)
        {
            try
            {
                bool isSuccess = await _cartRepository.ClearCart(userId);
                _responseDto.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess =false;
                _responseDto.ErrorMassages = new List<string> { ex.Message };
                throw;
            }
            return _responseDto;
        }
    }
}
