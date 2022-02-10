using Microsoft.EntityFrameworkCore;
using Lab3_ContactManager.Models;

var builder = WebApplication.CreateBuilder(args);


// configure the website we will use almost every labs
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
}
);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DataBase Configuration
builder.Services.AddDbContext<ContactContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("ContactContext"))
);

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseRouting();

// app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
