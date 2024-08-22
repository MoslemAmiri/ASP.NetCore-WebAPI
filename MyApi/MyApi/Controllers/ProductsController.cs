using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product(1, "IPhone 13 Pro Max", 299, "Medan China"),
            new Product(2, "Galaxy Ultra S24", 289, "Medan Japan"),
            new Product(3, "Sony Xperia 1 III", 322, "Medan American")
        };

        [HttpGet]
        public List<Product> Products()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public Product GetProductBy(int id)
        {
            return _products.Find(x => x.Id == id);
        }

        [HttpPost]
        public List<Product> AddProduct(Product product)
        {
            _products.Add(product);
            return _products;
        }
    }
}