
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
        static ProductService()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Name = "dfhsfs",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "tergdbvf",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "wertgdf",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "jkhgkgfh",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "werhgfd",
                    Color = "#E2E2E2"

                },
                new Product
                {
                    Name = "nhgfvc",
                    Color = "#E2E2E2"

                }
            };
        }

        public static List<Product> Products;
        public static Product _product;


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












