using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ItProduct1.Models;
using System;
using System.Linq;

namespace ItProduct1.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ItProduct1.Data.AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ItProduct1.Data.AppDbContext>>()))
            {
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
     new Product
     {
         Name = "Laptop",
         Price = 999.99M,
         Description = "High-performance laptop for professional use",
         ImageUrl = "laptop_image_url_here",
         CustomerReview = 4.5
     },
     new Product
     {
         Name = "Desktop Computer",
         Price = 1499.99M,
         Description = "Powerful desktop computer with advanced specs",
         ImageUrl = "desktop_computer_image_url_here",
         CustomerReview = 4.2
     },
     new Product
     {
         Name = "Wireless Mouse",
         Price = 29.99M,
         Description = "Ergonomic wireless mouse with customizable buttons",
         ImageUrl = "wireless_mouse_image_url_here",
         CustomerReview = 4.7
     },
     new Product
     {
         Name = "Mechanical Keyboard",
         Price = 79.99M,
         Description = "RGB backlit mechanical keyboard for gaming enthusiasts",
         ImageUrl = "mechanical_keyboard_image_url_here",
         CustomerReview = 4.8
     },
     new Product
     {
         Name = "External Hard Drive",
         Price = 89.99M,
         Description = "Portable external hard drive for data backup",
         ImageUrl = "external_hard_drive_image_url_here",
         CustomerReview = 4.4
     },
     new Product
     {
         Name = "Wireless Headphones",
         Price = 129.99M,
         Description = "Noise-canceling wireless headphones for immersive audio experience",
         ImageUrl = "wireless_headphones_image_url_here",
         CustomerReview = 4.6
     },
     new Product
     {
         Name = "Gaming Monitor",
         Price = 349.99M,
         Description = "High refresh rate gaming monitor for smooth gameplay",
         ImageUrl = "gaming_monitor_image_url_here",
         CustomerReview = 4.5
     },
     new Product
     {
         Name = "Network Switch",
         Price = 199.99M,
         Description = "Managed network switch for efficient data transfer",
         ImageUrl = "network_switch_image_url_here",
         CustomerReview = 4.3
     },
     new Product
     {
         Name = "Smartphone",
         Price = 799.99M,
         Description = "Flagship smartphone with advanced camera and performance",
         ImageUrl = "smartphone_image_url_here",
         CustomerReview = 4.6
     },
    new Product
    {
        Name = "Wireless Router",
        Price = 129.99M,
        Description = "Dual-band wireless router for high-speed internet connectivity",
        ImageUrl = "wireless_router_image_url_here",
        CustomerReview = 4.4
    }

                );
                context.SaveChanges();



            }

        }

    }
}