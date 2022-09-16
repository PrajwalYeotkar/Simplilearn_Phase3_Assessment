using LaptopsOnline.Data;
using LaptopsOnline.Models;
using LaptopsOnline.Services;
using LittlePacktBookStore.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers(options => options.EnableEndpointRouting = false);
builder.Services.AddDbContext<LaptopsOnlineDbContex>(dbContextOptionBuilder =>
dbContextOptionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LaptopsOnline;Trusted_Connection=True;MultipleActiveResultSets=true"));
builder.Services.AddScoped<IRepository<Laptop>, SqlLaptopsRepository>();
builder.Services.AddScoped<IRepository<Carousel>, SqlCarouselsRepository>();
builder.Services.AddScoped<IRepository<Order>,SqlOrdersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseMvc(ConfigureRoutes);


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

//Configure Routes sets the route to the index page 
static void ConfigureRoutes(IRouteBuilder routes)
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
}