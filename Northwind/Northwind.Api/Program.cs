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

//swagger ile ilgili ba��ml�l�klar� ekle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddFluentValidationAutoValidation(c =>
{
    c.DisableDataAnnotationsValidation = true; //dataannotation validasyonunu kald�r�r. Dataannotation kullan�lmayacaksa performans� art�r�r.
}).AddValidatorsFromAssemblyContaining<ProductValidator>(); //ProductValidator nesnesinin tan�ml� oldu�u assemblydeki t�m validasyonlar� ekle (Northwind.Api)

//builder.Services.AddTransient<NorthwindContext>();
//builder.Services.AddScoped<NorthwindContext>(); //bir istek boyunca tek instance olu�turur
//builder.Services.AddSingleton<NorthwindContext>(); //uygulama bazl� instance olu�turur

builder.Services.AddDbContext<NorthwindContext>(opt =>
{
    //var constr = builder.Configuration.GetSection("ConnectionStrings")["NorthwindConnection"]; //("ConnectionStrings")["NorthwindConnection"] json dosyas�n�n i�inde
    //var constr = builder.Configuration.GetValue<string>("ConnectionStrings:NorthwindConnection");
    var constr = builder.Configuration.GetConnectionString("NorthwindConnection");
    opt.UseSqlServer(constr);
}); //hi� bir�ey belirtilmedi�inde scoped olur

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => //authentication konfigurasyonlar�. JWT Token
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
        RoleClaimType="role", //claim role AccountsController i�inde tan�mland�
        NameClaimType= "username",
    };
});

var app = builder.Build();

if (builder.Environment.IsDevelopment()) //development ortam�ndaysa
{
    app.UseSwagger(); // ilgili JSON i�eri�ini olu�turmas� i�in (wsdl i�eri�ine benzer i�erik)
    app.UseSwaggerUI();  //swagger�n aray�z� olu�turmas� i�in

}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers(); //mapget, mappost.. yerine routelar� controllerlara g�re map et

app.Run();
