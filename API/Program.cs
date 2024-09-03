//Minimal APIs em C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//funcionalidades 
//requisicao - url e um metodo/verbo HTTP
app.MapGet("/", () => "olaaaaaaaaaaa");

app.Run();
