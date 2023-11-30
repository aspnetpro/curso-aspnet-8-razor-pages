using AulaRazorPages.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services
    .AddDbContext<MoviesContext>(option =>
        option.UseInMemoryDatabase("MyFirstAppDB"));

var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/errors/{0}");
//app.UseStatusCodePagesWithRedirects("/errors/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.Run();
