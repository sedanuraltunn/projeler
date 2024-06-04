using Microsoft.EntityFrameworkCore;

namespace MappingDemo;

public class MsbStoreContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDb; Initial Catalog= MsbStoreMapping; Integrated Security=true; ");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) //fluent mapping 
    {                                                                  //mapping çok karmaşıksa konfigrasyon dosyası kullanılarak yapılması tercih edilir.

        modelBuilder.Entity<Product>().ToTable("Urunler","dbo");
        modelBuilder.Entity<Product>().HasKey(p=>p.Id); //birden fazla key varsa anonim tip kullanılır
        //modelBuilder.Entity<Product>().HasNoKey(); //tabloda primary key yoksa (heap tablo ise)
        modelBuilder.Entity<Product>().Property(t => t.Name).HasColumnName("Ad").IsRequired();
        modelBuilder.Entity<Product>().Property(t => t.Description).HasColumnName("Aciklama").HasColumnType("varchar").HasMaxLength(250);
        modelBuilder.Entity<Product>().HasQueryFilter(t => !t.IsDeleted); //product ile ilgili yapılacak tüm sorgulara !t.IsDeleted şartını ekler.
                                                                          //Adminin bu filtreye tabi olmaması için şart program.cs'e eklendi
        modelBuilder.Entity<Product>().HasChangeTrackingStrategy(ChangeTrackingStrategy.Snapshot);
        base.OnModelCreating(modelBuilder);
    }
}
