using DemoInterfaceService.Models.Entities;
using DemoInterfaceService.Repositories.Khoas;
using DemoInterfaceService.Repositories.SinhViens;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DemoDbContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
// Add services to the container.
builder.Services.AddScoped<IKhoaRepository<Khoa, Guid>, KhoaRepository>();
builder.Services.AddScoped<ISinhVienRepository<SinhVien, Guid>, SinhVienRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x => x.DefaultModelsExpandDepth(-1));
}

app.UseAuthorization();

app.MapControllers();

app.Run();
