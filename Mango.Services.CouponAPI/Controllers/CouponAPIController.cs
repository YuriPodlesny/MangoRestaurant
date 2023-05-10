using Mango.Services.CouponAPI.Models.Dto;
using Mango.Services.CouponAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponAPIController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        private readonly ResponseDto _responseDto;

        public CouponAPIController(ICouponRepository cartRepository)
        {
            _couponRepository = cartRepository;
            _responseDto = new ResponseDto();
        }
        
        [HttpGet("{code}")]
        public async Task<object> GetDiscountForCode(string code)
        {
            try
            {
                CouponDto couponDto = await _couponRepository.GetCouponByCode(code);
                _responseDto.Result = couponDto;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMassages = new List<string>() { ex.Message };
                throw;
            }
            return _responseDto;
        }
    }
}
