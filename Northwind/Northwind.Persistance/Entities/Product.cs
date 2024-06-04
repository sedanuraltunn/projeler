namespace Northwind.Persistance.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
    } 
}
