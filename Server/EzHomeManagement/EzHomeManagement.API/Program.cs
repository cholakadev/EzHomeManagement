using EzHomeManagement.Data;
using EzHomeManagement.Data.Abstraction;
using EzHomeManagement.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<ApplicationDbContext>(options => options
        .UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]),
        ServiceLifetime.Transient
    );

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
