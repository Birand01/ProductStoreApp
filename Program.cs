using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;


var builder = WebApplication.CreateBuilder(args);
SQLitePCL.Batteries.Init();

builder.Services.AddDbContext<RepositoryContext>(options=>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
builder.Services.AddScoped<IRepositoryManager,RepositoryManager>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();


builder.Services.AddControllersWithViews(); 
var app = builder.Build();

app.UseStaticFiles(); // for the usage of static files configuration (wwwroot)
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
