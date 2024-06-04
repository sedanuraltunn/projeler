using Microsoft.AspNetCore.Mvc;
using Northwind.Persistance.Context;
using Northwind.Persistance.Entities;

namespace Northwind.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly NorthwindContext _context;
    public CategoriesController(NorthwindContext context) //,IConfiguration configuration //appsettings dosyasındaki constringe ulaşmak için
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(Category[]))] //IActionresult dönüldüğünde dönüş tipi belli olmadığından (Schema yok) tipi bu attributeda belirtilir
    public IActionResult Get()
    {
        //using var context = new NorthwindContext();
        var res = _context.Categories.ToList();
        return Ok(res);
    }

    [HttpGet("{id:int}/products")]
    [ProducesResponseType(200, Type = typeof(Product[]))]
    public IActionResult Get(int id) //parametre istendiğinde model binding devreye girer.
    {
        //using var context = new NorthwindContext();
        var res = _context.Products.Where(x => x.CategoryId == id).ToList();
        return Ok(res);
    }
}
