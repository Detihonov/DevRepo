// WebApplication.CreateBuilder(args) создает объект WebApplicationBuilder,
// который используется для настройки и запуска веб-приложения.
// args — это аргументы командной строки, переданные в приложение.

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers() добавляет поддержку контроллеров в приложение.
// Это позволяет использовать контроллеры для обработки HTTP-запросов.

builder.Services.AddControllers();

// builder.Services.AddOpenApi() добавляет поддержку OpenAPI (Swagger) в приложение.
// Это позволяет генерировать документацию API и предоставлять ее через Swagger UI.

builder.Services.AddOpenApi();

// builder.Build() создает экземпляр WebApplication на основе настроек, указанных в WebApplicationBuilder.

var app = builder.Build();

// app.Environment.IsDevelopment() проверяет, находится ли приложение в режиме разработки.
// app.MapOpenApi() добавляет конечную точку для OpenAPI (Swagger).
// app.UseSwaggerUI настраивает Swagger UI для отображения документации API. 
// options.SwaggerEndpoint("/openapi/v1.json", "DevQuestion") указывает путь к файлу OpenAPI и заголовок для Swagger UI.

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "DevQuestion"));
}

// app.MapControllers() добавляет маршрутизацию для контроллеров.
// Это позволяет обрабатывать HTTP-запросы с помощью контроллеров.

app.MapControllers();

// app.Run() запускает веб-приложение и начинает прослушивать входящие HTTP-запросы.

app.Run();
