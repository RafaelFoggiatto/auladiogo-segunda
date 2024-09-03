//Minimal APIs em C#
//Testar API
// - Rest Client - Extensao VS Code
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//funcionalidades 
//requisicao - url e um metodo/verbo HTTP
app.MapGet("/", () => "Hello Word em C#");

app.MapGet("/segundafuncionalidade", () => "Segunda funcionalidade");

app.Run();
//para próxima aula 
// - criar um endpoint para receber informacao pela URL