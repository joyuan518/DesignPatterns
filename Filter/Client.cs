namespace DesignPatterns.Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Client
    {
        public static void Run()
        {
            var categoryCriteria = new CategoryCriteria(Category.Books);
            var priceCriteria = new PriceCriteria(20);
            var andCriteria = new AndCriteria(new List<Criteria> { categoryCriteria, priceCriteria});

            var products = new List<Product> {
                new Product { Id = 1, Name = "CLR via C#", Category = Category.Books, Price = 20},
                new Product { Id = 2, Name = "Think in Java", Category = Category.Books, Price = 40},
                new Product { Id = 3, Name = "Hungry Jack Pancake Mix", Category = Category.Food, Price = 20}
            };

            var filteredProducts = products.FindAll(p => andCriteria.Meet(p));

            filteredProducts.ForEach(p => Console.WriteLine($"Product ID: {p.Id}, Product Name: {p.Name}"));            
        }
    }
}