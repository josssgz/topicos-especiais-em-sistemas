var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// FUNCIONALIDADES - ENDPOINTS
// REQUISIÇÃO - REQUEST
// - URL
// - 
app.MapGet("/", () => "Primeira API");

app.MapGet("/segundaurl", () => "Segunda funcionalidade");

app.Run();
