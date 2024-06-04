using FirstDemo;

using (var context = new MsbStoreContext()) //yönetilmeyen kaynaklar (vt bağlantıları, dosya okuma yazma işlemleri vb.) using ile kullanılmalıdır
{
    context.Database.EnsureCreated();
};

Console.WriteLine("db işlemi tamamlandı");