
using CW9and10.Models.Entites;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CW9and10.Controllers
{
    public class ProductController : Controller
    {

   
   
        
        public List<Product> Products { get;  set; }
       



        public IActionResult List()
        {
            Products= ProductService.GetProducts();
        
            return View(Products);
        }
     
        public IActionResult Create(Product product)
        {
         ProductService.AddProduct(product);
            return View();
        }


    }
}
