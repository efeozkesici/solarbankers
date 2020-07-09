using System.Collections.Generic;   
using System.Threading.Tasks;
using Market.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BillingMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpPost("bill")]
        public async Task<IActionResult> Billing(List<string> CodeList)
        {
            var result = await _saleService.Billing(CodeList);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

    }
}
