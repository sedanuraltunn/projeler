﻿namespace LinqDemo.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public int CategoryId { get; set; }
    public string QuantityPerUnit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public bool Discontinued { get; set; }
}
