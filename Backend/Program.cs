using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger in all environments (optional)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "GuitarApp API V1");
    c.RoutePrefix = "swagger"; // optional, default is "swagger"
});


// Middlewares
app.UseHttpsRedirection();
app.UseAuthorization();

// Map controllers
app.MapControllers();

// Run app
app.Run();