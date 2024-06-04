using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Northwind.Api.Validators;
using Northwind.Persistance.Context;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//swagger ile ilgili baðýmlýlýklarý ekle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddFluentValidationAutoValidation(c =>
{
    c.DisableDataAnnotationsValidation = true; //dataannotation validasyonunu kaldýrýr. Dataannotation kullanýlmayacaksa performansý artýrýr.
}).AddValidatorsFromAssemblyContaining<ProductValidator>(); //ProductValidator nesnesinin tanýmlý olduðu assemblydeki tüm validasyonlarý ekle (Northwind.Api)

//builder.Services.AddTransient<NorthwindContext>();
//builder.Services.AddScoped<NorthwindContext>(); //bir istek boyunca tek instance oluþturur
//builder.Services.AddSingleton<NorthwindContext>(); //uygulama bazlý instance oluþturur

builder.Services.AddDbContext<NorthwindContext>(opt =>
{
    //var constr = builder.Configuration.GetSection("ConnectionStrings")["NorthwindConnection"]; //("ConnectionStrings")["NorthwindConnection"] json dosyasýnýn içinde
    //var constr = builder.Configuration.GetValue<string>("ConnectionStrings:NorthwindConnection");
    var constr = builder.Configuration.GetConnectionString("NorthwindConnection");
    opt.UseSqlServer(constr);
}); //hiç birþey belirtilmediðinde scoped olur

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => //authentication konfigurasyonlarý. JWT Token
{
    var issuer = "http://abc.com";
    var key = "komplex_salt_key";
    SymmetricSecurityKey issuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = issuer,
        IssuerSigningKey = issuerSigningKey, 
        ValidateLifetime = true,
        ValidateIssuer = true,
        ValidateIssuerSigningKey = true,
        ValidateAudience= false,
        RoleClaimType="role", //claim role AccountsController içinde tanýmlandý
        NameClaimType= "username",
    };
});

var app = builder.Build();

if (builder.Environment.IsDevelopment()) //development ortamýndaysa
{
    app.UseSwagger(); // ilgili JSON içeriðini oluþturmasý için (wsdl içeriðine benzer içerik)
    app.UseSwaggerUI();  //swaggerýn arayüzü oluþturmasý için

}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers(); //mapget, mappost.. yerine routelarý controllerlara göre map et

app.Run();
