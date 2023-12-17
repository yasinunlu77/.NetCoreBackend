using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
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

        public IActionResult Detail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
