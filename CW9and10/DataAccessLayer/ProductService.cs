
using CW9and10.Models.Entites;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace DataAccessLayer
{
    public class ProductService
    {
        
        public static  List<Product> Products;
        public static  Product _product;

        public static List<Product> GetProducts()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "asqar",
                    Color = "#E2E2E2"

                }

            };
            return Products;
        }
        public static void AddProduct(Product product)
        {
           Products.Add(product);
        }
    }
}

        


            //public IEnumerable<Product> GetProducts()
            //{
            //    using (var jsonFileReader = File.OpenText(JsonFileName))
            //    {
            //        Products = JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
            //            new JsonSerializerOptions
            //            {
            //                PropertyNameCaseInsensitive = true
            //            });
            //    }
            //    return Products;
            //}










        
    
