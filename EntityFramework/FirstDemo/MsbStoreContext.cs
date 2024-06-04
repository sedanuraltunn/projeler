
using Microsoft.EntityFrameworkCore;

namespace FirstDemo;

public class MsbStoreContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDb; Initial Catalog= MsbStore; Integrated Security=true; ");
        base.OnConfiguring(optionsBuilder);
    }
}
