//Minimal APIs em C#
//Testar API
// - Rest Client - Extensao VS Code
// - Postman
// - Insomnia
//namespace API.Models;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//funcionalidades 
//requisicao - url e um metodo/verbo HTTP
//GET: /
app.MapGet("/", () => "API de Produtos");

//POST: / api/produto/cadastrar/param_nome
app.MapGet("/api/produto/cadastrar/{nome}", () => {
    Produto produto = new Produto();
    produto.Nome = "nome_url";
    produtos.Add(produto);
    return produtos;
});





app.Run();
//para próxima aula 
// - criar um endpoint para receber informacao pela URL

//Produto produto = new Produto();
//produto.Nome = "NoteBook";