
using CW9and10.Models.Entites;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace CW9and10.Controllers
{
    public class ProductController : Controller
    {

        public List<Product> Products { get;  set; }
        public IActionResult List()
        {
            Products= ProductService.Products;
        
            return View(Products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Title, string Color)
        {
            var pro = new Product() { Color = Color, Name = Title };

            ProductService.AddProduct(pro);

            var x = ProductService.Products;
            return RedirectToAction("List");
        }

        public IActionResult Delete(string name)
        {
           foreach (var item in ProductService.Products)
            {
                if(item.Name == name)
                {
                    ProductService.Products.Remove(item);
                    break;
                }
            }
            return RedirectToAction("List");

        }




        
        public IActionResult Edit(string name)
        {
            foreach (var item in ProductService.Products)
            {
                if (item.Name == name)
                {
                    return View(item);
                }
            }
            return RedirectToAction("List");

        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            foreach (var item in ProductService.Products)
            {
                if (item.Name == product.Name)
                {
                   item.Name = product.Name;
                   item.Color = product.Color; 
                }
            }
            return RedirectToAction("List");

        }

    }
}
