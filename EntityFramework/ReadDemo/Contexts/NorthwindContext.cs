using Microsoft.EntityFrameworkCore;
using ReadDemo.Entities;

namespace ReadDemo.Contexts;

public class NorthwindContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDb; Initial Catalog= Northwind; Integrated Security=true; ");
        base.OnConfiguring(optionsBuilder);
    }
}
