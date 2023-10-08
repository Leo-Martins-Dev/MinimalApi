using MinimalApi.Models;

namespace MinimalApi.Services
{
    public class ProductServiceMock
    {
        public Product GetProduct(int id)
        {
            return new Product
            {
                Id = 1,
                Name = "Product 1",
                Description = "This is product 1.",
                Price = 100
            };
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Description = "This is product 1.",
                Price = 100
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Description = "This is product 2.",
                Price = 200
            }
        };
        }
    }

}