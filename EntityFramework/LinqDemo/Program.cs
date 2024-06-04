using LinqDemo.Contexts;
using LinqDemo.Entities;
using System.Xml.Linq;

using (var context = new NorthwindContext())
{
    //var products = (from p in context.Products
    //               select p).ToList();

    //var products = (from p in context.Products
    //                select new { p.ProductName, p.UnitPrice }).ToList();

    //var products = (from p in context.Products
    //                where p.CategoryId== 1
    //                select p).ToList();

    //var products = (from p in context.Products 
    //                orderby p.ProductName
    //                select p).ToList();

    //var countries = (from c in context.Customers
    //                group c by c.Country into g
    //                select g.Key).ToList();

    //var products = (from c in context.Customers
    //                group c by new { c.Country, c.City } into g
    //                select new { g.Key.Country, g.Key.City, Total = g.Count() }).ToList();


    //var enPahaliFiyat = (from p in context.Products
    //                select p.UnitPrice).Max();

    //Product? product = (from p in context.Products where p.ProductId == 3 select p).SingleOrDefault();

    //var products = (from p in context.Products
    //               join c in context.Categories
    //               on p.CategoryId equals c.CategoryId
    //               select new {p.ProductName, c.CategoryName}).ToList();


    //var products = (from p in context.Products
    //               join c in context.Categories
    //               on p.CategoryId equals c.CategoryId
    //               select new {p.ProductName, c.CategoryName}).ToList();

    // var products = (from p in context.Products
    //                  join c in context.Categories
    //                  on new { p.CategoryId, Name=p.ProductName } equals new{ c.CategoryId, Name = c.CategoryName }
    //                  select new { p.ProductName, c.CategoryName }).ToList();

    //var products = (from p in context.Products
    //                join c in context.Categories on p.CategoryId equals c.CategoryId
    //                join m in context.Customers on c.CategoryName equals m.CustomerId
    //                select new { p.ProductName, c.CategoryName, m.CompanyName }).ToList();


    var products = (from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.CategoryId into ps
                    from c in ps.DefaultIfEmpty()
                    select new 
                    { 
                        p.ProductName, 
                        c.CategoryName 
                    }).ToList();
}