using System.Collections.Generic;
using AspNetMVC.LabExercise1.Models;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Iphone1",
                Description = "IPhone 1 New Model",
                Quantity = 10,
                Price = 2_000M,
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Iphone2",
                Description = "IPhone 2 New Model",
                Quantity = 9,
                Price = 4_000M,
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Iphone3",
                Description = "IPhone 3 New Model",
                Quantity = 8,
                Price = 6_000M,
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Iphone4",
                Description = "IPhone 4 New Model",
                Quantity = 7,
                Price = 8_000M,
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Iphone5",
                Description = "IPhone 5 New Model",
                Quantity = 6,
                Price = 10_000M,
            });

            products.Add(new Product()
            {
                Id = 6,
                Name = "Iphone6",
                Description = "IPhone 6 New Model",
                Quantity = 5,
                Price = 12_000M,
            });

            products.Add(new Product()
            {
                Id = 7,
                Name = "Iphone7",
                Description = "IPhone 7 New Model",
                Quantity = 4,
                Price = 14_000M,
            });

            products.Add(new Product()
            {
                Id = 8,
                Name = "Iphone8",
                Description = "IPhone 8 New Model",
                Quantity = 3,
                Price = 16_000M,
            });

            products.Add(new Product()
            {
                Id = 9,
                Name = "Iphone9",
                Description = "IPhone 9 New Model",
                Quantity = 2,
                Price = 18_000M,
            });

            products.Add(new Product()
            {
                Id = 10,
                Name = "Iphone10",
                Description = "IPhone 10 New Model",
                Quantity = 1,
                Price = 20_000M,
            });
        }
        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (Product product in products)
            {
                grandTotal += product.TotalAmount;
            }
            return grandTotal;
        }
    }
}
