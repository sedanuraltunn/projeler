//orta ve büyük ölçekli uygulamalar iin MVC desenini kullanan API tercih edilmeli. Minimal API uygun deðil

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
//bu kýsma yazýlan middlewarelarýn sýrasý önemlidir.

app.MapGet("/", () =>
{
    return "merhaba dünya";
});

app.MapGet("musteriler", () =>
{
    return new[]
    {
        new{
        Id=Guid.NewGuid(),
        SiskeyAdi="SLD Yazilim",
        Kisi="Salih demirog"
        },

        new{
        Id=Guid.NewGuid(),
        SiskeyAdi="SLD Yazilim",
        Kisi="Salih demirog" },

        new{
        Id=Guid.NewGuid(),
        SiskeyAdi="SLD Yazilim",
        Kisi="Salih demirog"}

     };
});

//app.MapGet("musteriler/1", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SiskeyAdi = "SLD Yazilim",
//        Kisi = "Salih demirog"
//    };
//});

//app.MapGet("musteriler/2", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SiskeyAdi = "CAT Yazilim",
//        Kisi = "Cüneyt Tahmaz"
//    };
//});

app.MapGet("musteriler/{id:int}", (int id) => //çalýþtýrýlmasý gereken parametre varsa model binding devreye girer. Sýrasýyla Form fields,
                                              //The request body(For controllers that have the[ApiController] attribute.)
                                              //Route data,Query string parameters, Uploaded files' a bakar
                                              //{id:int} root kýsýtýdýr. id sayýsal deðer olmalý
{
    return new
    {
        Id = id,
        SiskeyAdi = "CAT Yazilim",
        Kisi = "Cüneyt Tahmaz"
    };
});

app.Run();


