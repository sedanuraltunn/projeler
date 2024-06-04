using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.Persistance.Context;
using Northwind.Persistance.Entities;

namespace Northwind.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly NorthwindContext _context;

    public ProductsController(NorthwindContext context)
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(Product[]))]
    public IActionResult Get()
    {
        //using var context = new NorthwindContext(); 
        var res = _context.Products.ToList();
        return Ok(res);
    }

    [Authorize] //kişinin kimliğinin doğrulanmış olması yeterli
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
    public IActionResult Get(int id)
    {
        //using var context = new NorthwindContext();
        var product = _context.Products.SingleOrDefault(x => x.Id == id);
        return Ok(product);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] Product product) //sadece bodyden gelen veriyi okur
    {
        //HttpContext.Request.Cookies - gelen istekleri yakalamak için
        //using var context = new NorthwindContext();
        _context.Products.Add(product);
        _context.SaveChanges();
        return Created(string.Empty, null); //ilk parametre headerdaki location'ın karşılığı. İstenirse yeni eklenen veriye ulaşılabilecek adres göderilebilir
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Put(int id, [FromBody] Product product) //sadece bodyden gelen veriyi okur
    {
        //HttpContext.Request.Cookies - gelen istekleri yakalamak için
        //using var context = new NorthwindContext();
        var addedproduct = _context.Products.SingleOrDefault(t => t.Id == id);
        addedproduct.UnitsInStock = product.UnitsInStock;
        addedproduct.UnitPrice = product.UnitPrice;
        addedproduct.QuantityPerUnit = product.QuantityPerUnit;
        addedproduct.Discontinued = product.Discontinued;
        addedproduct.CategoryId = product.CategoryId;
        addedproduct.Name = product.Name;

        _context.SaveChanges();
        return Ok();
    }

    [Authorize(Roles = "Admin")] //kimliği doğrulanmış ve rolü admin olanlar
    [HttpDelete("{id:int}")]
    [ProducesResponseType(204)]
    public IActionResult Delete(int id)
    {
        //using var context = new NorthwindContext();
        _context.Products.Remove(new Product
        { Id = id });
        _context.SaveChanges();
        return NoContent();
    }



}
