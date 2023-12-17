using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAPPMVC.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager;

        public ProductController()
        {
            _productManager = new ProductManager(new EFProductDal());
        }

        public IActionResult Index()
        {
            List<Product> _products = new List<Product>();
            foreach (var product in _productManager.GetAll().Data)
            {
                _products.Add(product);
            }

            return View("Index", _products);
        }

        public IActionResult Privacy()
        {
            return View("Index");
        }

        
    }
}
