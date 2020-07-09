using System.Collections.Generic;
using System.Threading.Tasks;
using MarketMicroservice.Business.Models;
using MarketMicroservice.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarketMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetProductList()
        {
            var result = await _productService.GetProducts();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await _productService.GetProductById(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct([FromBody] ProductModel product)
        {
            var result = await _productService.AddProduct(product);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("buy")]
        public async Task<IActionResult> BuyProduct([FromBody]string[] CodeList)
        {
            var result = await _productService.BuyProduct(CodeList);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPut("puptade/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductModel product)
        {
            var result = await _productService.UpdateProduct(id,product);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPut("suptade/{id}")]
        public async Task<IActionResult> UpdateStock(int id, int stock)
        {
            var result = await _productService.UpdateStock(id,stock);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }


        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _productService.DeleteProduct(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
    }
}
