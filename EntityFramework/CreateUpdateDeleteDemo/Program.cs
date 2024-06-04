using CreateUpdateDeleteDemo.Contexts;
using CreateUpdateDeleteDemo.Entities;

//AddDemo();
//AddDemo2(); 
//UpdateDemo();

//DeleteDemo();

//using (var context = new NorthwindContext())
//{
//    var product = context.Products.Find(78);
//    product.UnitPrice = 15;
//    context.SaveChanges();

//}

Console.WriteLine("bitti");

static void AddDemo()
{
    using (var context = new NorthwindContext())
    {
        var newCategory = new Category
        {
            CategoryName = "Gıda"
        };
        context.Categories.Add(newCategory);
        context.SaveChanges();
    }
}

static void AddDemo2()
{
    using (var context = new NorthwindContext())
    {
        var newProduct = new Product
        {
            ProductName = "Ekmek",
            QuantityPerUnit = "200 gr kepekli ekmek",
            UnitPrice = 25,
            UnitsInStock = 5,
            CategoryId = 9,
            Discontinued = false
        };
        context.Products.Add(newProduct);
        context.SaveChanges();
    }
}

static void UpdateDemo()
{
    using (var context = new NorthwindContext())
    {
        var product = context.Products.Find(78);
        product.UnitPrice = 15;
        context.Products.Update(product); //update metodu belirtilen id varsa update eder yoksa insert eder, hata vermez. Bu sebeple tercih edilmez. (EFCore'da var, EF'de yok)
        context.SaveChanges();

    }
}

static void DeleteDemo()
{
    using (var context = new NorthwindContext())
    {
        var product = new Product
        {
            ProductId = 78,
        };

        context.Products.Remove(product);
        context.SaveChanges();
    }
}