//orta ve b�y�k �l�ekli uygulamalar iin MVC desenini kullanan API tercih edilmeli. Minimal API uygun de�il

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
//bu k�sma yaz�lan middlewarelar�n s�ras� �nemlidir.

app.MapGet("/", () =>
{
    return "merhaba d�nya";
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
//        Kisi = "C�neyt Tahmaz"
//    };
//});

app.MapGet("musteriler/{id:int}", (int id) => //�al��t�r�lmas� gereken parametre varsa model binding devreye girer. S�ras�yla Form fields,
                                              //The request body(For controllers that have the[ApiController] attribute.)
                                              //Route data,Query string parameters, Uploaded files' a bakar
                                              //{id:int} root k�s�t�d�r. id say�sal de�er olmal�
{
    return new
    {
        Id = id,
        SiskeyAdi = "CAT Yazilim",
        Kisi = "C�neyt Tahmaz"
    };
});

app.Run();


