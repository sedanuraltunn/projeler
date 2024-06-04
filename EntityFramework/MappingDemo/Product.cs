namespace MappingDemo;

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;
    public short UnitsInStock { get; set; }
    public decimal UnitePrice { get; set; }
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }
    public Category Category { get; set; } = null!; //ürünün bir kategorisi olabildiğiden category olarak kullanıldı."BİRE" çok ilişki
}
