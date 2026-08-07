using Microsoft.Extensions.Options;
using PokeApiConnection.Configuration;
using PokeApiConnection.PokeConnection;
using PokeBl.BL.Pokemon;
using PokeBl.BL.PokemonBL;
using PokeBl.Model.Pokemon;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Config
builder.Services.Configure<PokemonOptions>(
    builder.Configuration.GetSection("Pokemon"));
builder.Services.AddScoped(sp => sp.GetRequiredService<IOptions<PokemonOptions>>().Value);

//BL
builder.Services.AddScoped<IPokemonBL, PokemonBL>();

//DTO
builder.Services.AddScoped<IPokeApiGet<PokemonDTO>, PokeApiGet<PokemonDTO>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
