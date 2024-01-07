using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet("getAll")]//Alyas
        public IActionResult getAll()
        {
            var result = _productService.GetProductsDetails();
            if(result.success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            } 
        }

        [HttpGet("getById")]//Alyas
        public IActionResult getById(int id)
        {
            var result = _productService.GetByProductId(id);
            if (result.success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
