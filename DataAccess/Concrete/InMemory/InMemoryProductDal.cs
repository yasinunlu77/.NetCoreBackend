using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>{
                new Product{ProductId = 1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=2 },
                new Product{ProductId = 2, CategoryId=2, ProductName="Kamera", UnitPrice=15, UnitsInStock=2 },
                new Product{ProductId = 3, CategoryId=1, ProductName="Çaydanlık", UnitPrice=15, UnitsInStock=2 },
                new Product{ProductId = 4, CategoryId=2, ProductName="Klavye", UnitPrice=15, UnitsInStock=2 },
                new Product{ProductId = 5, CategoryId=2, ProductName="Fare", UnitPrice=15, UnitsInStock=2 },
            };
        }

        public void Add(Product entity) => _products.Add(entity);
        
        public void Delete(Product entity)
        {
            Product productDeleted = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            _products.Remove(productDeleted);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null
                ? _products
                : _products.ToList();

        }

        public List<ProductsDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<ProductsDetailDto> GetProductsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            //Gelen Id'ye sahip olan listedeki ürünü bul.
            Product productUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productUpdate.ProductName = entity.ProductName;
            productUpdate.CategoryId = entity.CategoryId;
            productUpdate.UnitPrice = entity.UnitPrice;
            productUpdate.UnitsInStock = entity.UnitsInStock;
            
        }
    }
}
