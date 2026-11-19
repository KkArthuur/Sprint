/*
GUARDADO POR SEGURANÇA!!!!
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();*/

using Sprint.Data;
WebApplicationBuilder builder =
 WebApplication.CreateBuilder(args);
// Habilita o uso de Controllers.
builder.Services.AddControllers();
// Registra a classe de conexão para que o ASP.NET Core
// possa fornecê-la ao ConexaoController.
builder.Services.AddSingleton<ConexaoBanco>();
WebApplication app = builder.Build();
// Disponibiliza as rotas declaradas nos Controllers.
app.MapControllers();
// Inicia a aplicação.
app.Run();