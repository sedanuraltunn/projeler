using TransactionDemo.Contexts;
using TransactionDemo.Entities;

using (var context = new NorthwindContext())
{
    //savechanges işlemini yapana kadar aynı transaction içerisinde devam eder.
    //Ayrı ayrı transaction yapılmak isteniyorsa birden fazla savechanges kullanılmalıdır.
    //Örnekte işlem tek transactionda gerçekleşiyor.

    context.Categories.Add(new Category { CategoryName = "Mobilya" });
    context.Categories.Add(new Category { CategoryName = "Elektronik" });

    context.Remove(new Category { CategoryId = 9 });

    context.Customers.Add(new Customer() //parametre almıyorsa () kullanılmayabilir
    { 
        City="Ankara", 
        CompanyName="SLD Yazılım", 
        ContactName="Salih Demirog", 
        Country="Türkiye", 
        CustomerId="ALFKI"});

    context.SaveChanges();
}