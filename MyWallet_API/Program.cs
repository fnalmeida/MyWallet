using Data.DBContext;
using Data.Repositories;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using MyWallet.Domain.Interfaces.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDBContext>();

// Handlers
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//Repositories
builder.Services.AddTransient<ILancamentoRepository, LancamentoRepository>();

//Todo: Consertar isso aqui
builder.Services.AddMediatR(typeof(MyWallet.Domain.Handlers.AtualizarLancamentoHandle));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();

//app.MapGet("/lancamentos", () =>
//{
//    return Results.Ok("achei o erro");
//})
//.WithName("GetLancamentos");


app.MapControllers();
app.Run();

