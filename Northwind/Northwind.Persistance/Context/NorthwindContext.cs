using Microsoft.EntityFrameworkCore;
using Northwind.Persistance.Configurations;
using Northwind.Persistance.Entities;

namespace Northwind.Persistance.Context;

public class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security=true;");
    //    base.OnConfiguring(optionsBuilder);

    //}

}
