using Microsoft.EntityFrameworkCore;
using ReadySetGo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FlashcardDbContext>(options => {
    options.UseSqlite(
        builder.Configuration["ConnectionStrings: FlashcardDbContextConnection"]);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();