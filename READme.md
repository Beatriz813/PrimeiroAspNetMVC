# Anotações sobre ASP.NET MVC

- As aplicações MVC têm: Models (objetos de manipulação), Controllers (fazem ações) e Views (páginas com conteúdo visível)
- A entrada de dados nos controllers é via requisição HTTP
- Os controllers retornam Views. Para retornar uma view eles devem retornar um IActionResult ou objeto que herde dessa interface ou de ActionResult.
- A estrutura de rotas fica de acordo com padrão feito no startup Configure()

```csharp
app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
```

esse metodo temos que ao construir um controller com o nome HelloWorldController.cs, por exemplo, para acessar ele e as suas actions (métodos) precisamos acessar /HelloWorld/NomeDoMetodo.

- É possivel fazer passagem de dados do controller para as views através do objeto ViewData. Ele é um objeto dinâmico, então é possível criar qualquer atibuto dentro dele da seguinte form: ```ViewData["NomeDaPropriedade"]```. Para acessar o ViewData de dentro da View basta acessar com ```@ViewData["NomeDaPropriedade"]```.
