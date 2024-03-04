using Microsoft.AspNetCore.Mvc;
using ItProduct1.Models;
using System.Collections.Generic;

namespace ItProduct1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve a list of products (sample data for demonstration)
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99M, Description = "High-performance laptop for professional use", ImageUrl = "/images/Laptop1.webp", CustomerReview = 4.4 },
                    new Product { Id = 2, Name = "Desktop Computer", Price = 1499.99M, Description = "Powerful desktop computer with advanced specs", ImageUrl = "/images/computer2.webp", CustomerReview = 5.0 },
                    new Product { Id = 3, Name = "Wireless Mouse", Price = 29.99M, Description = "Ergonomic wireless mouse with customizable buttons", ImageUrl = "/images/wirelessmouse3.jpg", CustomerReview = 4.7 },
                    new Product { Id = 4, Name = "Mechanical Keyboard", Price = 79.99M, Description = "RGB backlit mechanical keyboard for gaming enthusiasts", ImageUrl = "/images/keyboard4.jpg", CustomerReview = 3.9 },
                    new Product { Id = 5, Name = "External Hard Drive", Price = 89.99M, Description = "Portable external hard drive for data backup", ImageUrl = "/images/hard drive5.jpg", CustomerReview = 4.4f },
                    new Product { Id = 6, Name = "Wireless Headphones", Price = 129.99M, Description = "Noise-canceling wireless headphones for immersive audio experience", ImageUrl = "/images/headphones6.webp", CustomerReview = 4.5 },
                    new Product { Id = 7, Name = "Gaming Monitor", Price = 349.99M, Description = "High refresh rate gaming monitor for smooth gameplay", ImageUrl = "/images/gamingmonitor7.jpg", CustomerReview = 4.9 },
                    new Product { Id = 8, Name = "Network Switch", Price = 199.99M, Description = "Managed network switch for efficient data transfer", ImageUrl = "/images/switch8.jpg", CustomerReview = 4.2 },
                    new Product { Id = 9, Name = "Smartphone", Price = 799.99M, Description = "Flagship smartphone with advanced camera and performance", ImageUrl = "/images/Smartphone9.jpeg", CustomerReview = 4.8 },
                    new Product { Id = 10, Name = "Wireless Router", Price = 129.99M, Description = "Dual-band wireless router for high-speed internet connectivity", ImageUrl = "/images/router10.jpeg", CustomerReview = 4.4 }

        };

            return View(products);
        }
    }
}