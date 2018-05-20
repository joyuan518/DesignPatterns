namespace DesignPatterns.Facade.Services
{
    using Entities;

    public class ProductService
    {
        public Product GetProduct(int productId)
        {
            return new Product();
        }
    }
}