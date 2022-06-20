using AutoMapper;
using EzHomeManagement.API;
using EzHomeManagement.Business.Abstraction;
using EzHomeManagement.Business.AuthServicePack;
using EzHomeManagement.Data;
using EzHomeManagement.Data.Abstraction;
using EzHomeManagement.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IEntranceRepository, EntranceRepository>();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => options
        .UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]),
        ServiceLifetime.Transient
    );

var config = new MapperConfiguration(c => {
    c.AddProfile<ModelMapper>();
});

builder.Services.AddSingleton<IMapper>(s => config.CreateMapper());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
