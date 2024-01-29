using BookShop.Api.Entities;
using BookShop.Api.Models;
using BookShop.Api.Services;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
builder.Services.AddDbContext<BooksDbContext>(opions=>opions.UseSqlServer(builder.Services.BuildServiceProvider().GetRequiredService<IConfiguration>().GetConnectionString("BookShopApiConnectionString")) );
builder.Services.AddScoped<BogusDataSeeder>();
builder.Services.AddScoped<IBookShopRepository, BookShopRepository>();
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(DtoMappingProfile)));
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
using var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<BogusDataSeeder>();
seeder.Seed();

app.UseAuthorization();

app.MapControllers();

app.Run();
