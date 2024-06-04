

using MappingDemo;
using Microsoft.EntityFrameworkCore;

using (var context = new MsbStoreContext()) //yönetilmeyen kaynaklar (vt bağlantıları, dosya okuma yazma işlemleri vb.) using ile kullanılmalıdır
{
    context.Database.EnsureCreated();

    //var allProducts=context.Products.ToList();
    //var productsForAdmin = context.Products.IgnoreQueryFilters().ToList(); // products tablosunda uygulanan global filtreleri admin için ignore et
};

Console.WriteLine("db işlemi tamamlandı");