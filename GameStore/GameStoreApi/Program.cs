using GameStoreApi.Data;
using GameStoreApi.EndPoints;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connection);
builder.Services.AddScoped<GameStoreContext>();


var app = builder.Build();

app.MapGet("/", () => "Привет мир!!!");
app.MapGenresEndPoints();

await app.MigrateDbAsync();

app.Run();
