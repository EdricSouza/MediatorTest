using MediatorTeste.Application;
using MediatorTeste.Application.Handlers;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/Calcular2Numeros", async (IMediator mediator) =>
{
    var query = new CalcularNumeroQuery(10, 20);
    var resultado = await mediator.Send(query);
    return resultado;
})
.WithName("Calcular2Numeros");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Serves the endpoint specification as a JSON file
    app.UseSwaggerUI(); // Generates the interactive web UI webpage
}

app.Run();