
using TravelHub.Models;
using TravelHub.Data;
using Microsoft.EntityFrameworkCore;
using TravelHub.BLL.AutenticacaoBLL;
using TravelHub.Services.UsuarioService;
using TravelHub.BLL.ContaBLL;
using TravelHub.BLL.Conta;
using TravelHub.BLL.Seguranca;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
 );

builder.Services.AddScoped<IAutenticacaoBLL, AutenticacaoBLL>();
builder.Services.AddScoped<ISegurancaBLL, SegurancaBLL>();
builder.Services.AddScoped<IContaBLL, ContaBLL>();
builder.Services.AddScoped<UsuarioService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
