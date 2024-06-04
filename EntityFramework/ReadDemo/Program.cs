using Microsoft.EntityFrameworkCore;
using ReadDemo;
using ReadDemo.Contexts;
using ReadDemo.Entities;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

//SelectDemo();

//SelectDemo2();

//SelectDemo3();

//WhereDemo1();

//WhereLikeDemo();

//WhereDemo3();

//WhereDemo4();

//WhereDemo5();

//OrderByDemo();

//GroupByDemo1();

//GroupByDemo2();

//GroupByDemo3();

//DistinctDemo();

//GroupByDemo4();

//AllDemo();

//TopDemo();

//OffsetDemo();

//AggregateFuncDemo();

//FirstLastSingleDemo();

//AnyAllDemo();

//InnerJoinDemo();

using (var context = new NorthwindContext())
{
    var customerId = "ALFKI";

    //SELECT yaparken entity üzerinden (Customers.FromSqlInterpolated,FromSqlRaw) diğer işlemlerde Database.ExecuteSqlRaw,ExecuteSqlInterpolated üzerinden gidilir.
    //var customers = context.Database.ExecuteSqlRaw("UPDATE Customers SET ContactName='Seda Nur ALTUN' WHERE CustomerId={0}",customerId);
    //var customers = context.Database.ExecuteSqlInterpolated($"UPDATE Customers SET ContactName='Seda Nur ALTUN' WHERE CustomerId={customerId}");

    var customers = context.Customers.FromSqlInterpolated($"select * from Customers where country='Germany'").Where(x=>x.City=="Madrid").ToList();
}

    Console.WriteLine("bitti");
static void SelectDemo()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void SelectDemo2()
{
    using (var context = new NorthwindContext())
    {
        var productNames = context.Products.Select(x => x.ProductName).ToList();
        foreach (var product in productNames)
        {
            Console.WriteLine($"{product}");
        }
    }
}

static void SelectDemo3()
{
    using (var context = new NorthwindContext())
    {
        var productNames = context.Products.Select(t => new
        {
            t.ProductId,
            t.ProductName
        }).ToList();
        foreach (var product in productNames)
        {
            Console.WriteLine($"{product}");
        }
    }
}

static void WhereDemo1()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.Where(t => t.UnitPrice > 100).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void WhereLikeDemo()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.Where(x => x.ProductName.StartsWith("ch")).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void WhereDemo3()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.Where(x => x.UnitPrice < 50 && x.UnitsInStock == 0).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void WhereDemo4()
{
    using (var context = new NorthwindContext())
    {
        var categoryIdler = new List<int> { 1, 3, 5, 7, 9 };
        var products = context.Products.Where(x => categoryIdler.Contains(x.ProductId)).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void WhereDemo5()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.Where(x => (x.UnitPrice < 20 && x.UnitsInStock < 20) || (x.UnitPrice < 50 && x.UnitsInStock < 50)).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void OrderByDemo()
{
    using (var context = new NorthwindContext())
    {
        var products = context.Products.OrderBy(x => x.UnitsInStock).ThenBy(x => x.ProductName).ToList(); //önce UnitsInStock sonra ProductName'e göre sırala
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void GroupByDemo1()
{
    using (var context = new NorthwindContext())
    {
        var countries = context.Customers.GroupBy(x => x.Country).Select(t => t.Key).ToList(); //EF grupladığı alanları key propertysine set eder
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
    }
}

static void GroupByDemo2()
{
    using (var context = new NorthwindContext())
    {

        var countries = context.Customers.GroupBy(x => new { x.Country, x.City }).Select(t => new { Sehir = t.Key.City, Ulke = t.Key.Country }).ToList();
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
    }
}

static void GroupByDemo3()
{
    using (var context = new NorthwindContext())
    {

        var countries = context.Customers.GroupBy(x => new { x.Country, x.City }).
            Select(t => new { Sehir = t.Key.City, Ulke = t.Key.Country, Toplam = t.Count() }).ToList();
        foreach (var data in countries)
        {
            Console.WriteLine($"{data.Ulke} -> {data.Sehir} -> {data.Toplam}");
        }
    }
}

static void DistinctDemo()
{
    using (var context = new NorthwindContext())
    {

        var countries = context.Customers.Select(t => new { t.Country, t.City }).Distinct().ToList();
        foreach (var data in countries)
        {
            Console.WriteLine($"{data.Country} -> {data.City}");
        }
    }
}

static void GroupByDemo4()
{
    using (var context = new NorthwindContext())
    {

        var datas = context.Customers.GroupBy(x => x.Country).Where(x => x.Count() >= 10).
            Select(t => new { Country = t.Key, Total = t.Count() }).ToList();
        foreach (var data in datas)
        {
            Console.WriteLine($"{data.Country} -> {data.Total}");
        }
    }
}

static void AllDemo()
{
    using (var context = new NorthwindContext())
    {

        var datas = context.Customers.
            Where(x => x.CompanyName.ToLower().Contains("a")).
            GroupBy(x => new { x.Country, x.City, x.CompanyName })
            .Where(x => x.Count() >= 2).
            Select(x => new { x.Key.Country, x.Key.City, Total = x.Count() }).
            OrderByDescending(x => x.Total).
            ToList();
        foreach (var data in datas)
        {
            Console.WriteLine($"{data.Country} -> {data.City} -> {data.Total}");
        }
    }
}

static void TopDemo()
{
    using (var context = new NorthwindContext())
    {
        //var productNames = context.Products
        //    .Take(5) //sql'deki top ile aynı 
        //    .ToList();

        var productNames = context.Products
            .Take(5) //sql'deki top ile aynı
            .OrderByDescending(x => x.UnitPrice)
            .ToList();
        foreach (var product in productNames)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void OffsetDemo()
{
    using (var context = new NorthwindContext())
    {
        var productNames = context.Products
            .Skip(5) //sqldeki offset
            .Take(10)  //ilk 5 kaydı atla sonraki 10 kaydı getir.
            .OrderByDescending(x => x.UnitPrice)
            .ToList();
        foreach (var product in productNames)
        {
            Console.WriteLine($"{product.ProductId} -> {product.ProductName} -> {product.UnitPrice}");
        }
    }
}

static void AggregateFuncDemo()
{
    using (var context = new NorthwindContext())
    {
        var enPahaliUrunFiyati = context.Products.Max(t => t.UnitPrice);
        var enUcuzUrunFiyati = context.Products.Min(t => t.UnitPrice);
        var toplamStokAdedi = context.Products.Sum(t => t.UnitsInStock);
        var ortalamaUrunFiyati = context.Products.Average(t => t.UnitPrice);
        var toplamUrunAdedi = context.Products.Count();
        var stoguBulunmayanUrunAdedi = context.Products.Count(x => x.UnitsInStock == 0);
        Console.WriteLine($"enPahaliUrunFiyati: {enPahaliUrunFiyati}");
        Console.WriteLine($"enUcuzUrunFiyati: {enUcuzUrunFiyati}");
        Console.WriteLine($"toplamStokAdedi: {toplamStokAdedi}");
        Console.WriteLine($"ortalamaUrunFiyati: {ortalamaUrunFiyati}");
        Console.WriteLine($"toplamUrunAdedi: {toplamUrunAdedi}");
        Console.WriteLine($"stoguBulunmayanUrunAdedi: {stoguBulunmayanUrunAdedi}");
    }
}

static void FirstLastSingleDemo()
{
    using (var context = new NorthwindContext())
    {
        //Customer customer = context.Customers.First();
        //Customer customer2 = context.Customers.First(t=>t.CustomerId=="ANTON");
        //Customer customer7 = context.Customers.FirstOrDefault(t => t.CustomerId == "ANTON");
        //Customer customer3 = context.Customers.Last();
        //Customer customer4 = context.Customers.Last(t => t.Country == "Germany");
        //Customer customer8 = context.Customers.LastOrDefault(t => t.Country == "Germany");
        //Customer customer5 = context.Customers.Single(t => t.CustomerId == "ANTON");
        Customer customer6 = context.Customers.SingleOrDefault(t => t.CustomerId == "ANTON");
    }
}

static void AnyAllDemo()
{
    using (var context = new NorthwindContext())
    {
        bool isExist = context.Customers.Any(x => x.CustomerId == "SLD");
        bool isExists2 = context.Customers.Count(t => t.CustomerId == "SLD") > 0;
        Console.WriteLine($"SLD Müşterisi var mı: {isExist}");

        bool tumUrunlerBirLiradanPahali = context.Products.All(t => t.UnitPrice > 1);
        Console.WriteLine($"tum Urunler Bir Liradan Pahalı mı: {tumUrunlerBirLiradanPahali}");
    }
}

static void InnerJoinDemo()
{
    using (var context = new NorthwindContext())
    {
        //var products = context.Products.Join(context.Categories, p => p.CategoryId, c => c.CategoryId, (p, c) => new
        //{
        //    p.ProductId,
        //    p.ProductName,
        //    c.CategoryName,
        //    p.UnitPrice
        //}).ToList();

        var products = context.Products.Join(context.Categories, p => p.CategoryId, c => c.CategoryId, (p, c) => new ProductDto
        {
            Id = p.ProductId,
            Name = p.ProductName,
            CategoryName = c.CategoryName,
            UnitPrice = p.UnitPrice
        }).ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id}, {product.Name}, {product.CategoryName}");
        }
    }
}