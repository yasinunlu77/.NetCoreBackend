using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//ListNameOfProducts();
//ListNameOfCategories();
ProductsWithCategoryNames();
//ListNameOfProductsByUnitPrice(40,100);


/*
static void ListNameOfCategories()
{
    CategoryManager categories = new CategoryManager(new EFCategoryDal());
    foreach (var category in categories.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}
*/

/*
static void ListNameOfProducts()
{
    ProductManager products = new ProductManager(new EFProductDal());

    foreach (var product in products.GetAll())
    {
        Console.WriteLine(product.ProductName);
    }
}
*/

static void ProductsWithCategoryNames()
{
    ProductManager products = new ProductManager(new EFProductDal());

    var result = products.GetProductsDetails();

    if (result.success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " ----------------> " + product.CategoryName);
        }
        Console.WriteLine(result.Message);
    }
    else
    {
        Console.WriteLine(result.Message);
    }
    
    
}

/*
static void ListNameOfProductsByUnitPrice(Decimal min, Decimal max)
{
    ProductManager products = new ProductManager(new EFProductDal());

    foreach (var product in products.GetByUnitPrice(min,max))
    {
        Console.WriteLine(product.ProductName + "  " + product.UnitPrice);
    }
}
*/