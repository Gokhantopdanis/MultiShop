using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using MultiShop.Discount.Context;
using MultiShop.Discount.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// bu iþlemler baþladý //

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "ResourceDiscount";
    opt.RequireHttpsMetadata = false;
});



builder.Services.AddTransient<DapperContext>();

builder.Services.AddTransient<IDiscountService, DiscountService>();

// bitti //


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//baþladý
app.UseAuthentication();
//
app.UseAuthorization();

app.MapControllers();

app.Run();
