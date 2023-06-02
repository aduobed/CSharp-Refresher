using ContosoCraftsWebsite.Models;
using ContosoCraftsWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCraftsWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService ProductService { get; }

        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

    }
}
