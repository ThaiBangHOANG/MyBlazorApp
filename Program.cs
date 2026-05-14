using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddMemoryCache();

var app = builder.Build();
builder.Services.AddCors();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

// Enable CORS
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

// Product API
app.MapGet("/api/productlist", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new
            {
                Id = 101,
                Name = "Electronics"
            }
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new
            {
                Id = 102,
                Name = "Accessories"
            }
        }
    });
});

app.Run();

internal class WebApplication
{
}