using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.Client.Data;
using Shopping.Client.Models;

namespace Shopping.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ProductContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }
    }
}
