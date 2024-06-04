
namespace FirstDemo;

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;
    public short UnitsInStock { get; set; }
    public decimal UnitePrice { get; set; }
    public string? Description { get; set; }

    public Category Category { get; set; } = null!; //ürünün bir kategorisi olabildiğiden category olarak kullanıldı."BİRE" çok ilişki
}
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Product>? Products { get; set; } //bir kategoride birden fazla ürün olabileceği için ICollection kullanıldı. bire "ÇOK" ilişki
                                                        //List'i EF görmediğinden sağlıklı çalışmaz. ICollection kullanılmalı
}
