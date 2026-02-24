using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Services;
using DotNetWebApp.Services;
using DotNetWebApp.Interfaces;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddSingleton<WelcomeService>();
builder.Services.AddScoped<IWelcomeService, WelcomeService>();
builder.Services.AddSingleton<PersonService>();
var app = builder.Build();

app.Use(async (context, next) =>
{
    await next();
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
});

app.MapGet("/",
    (PersonService personService, IWelcomeService welcomeService) =>
    {
        return $"Hello, {personService.GetPersonName()}\n{welcomeService.GetWelcomeMessage()}!";
    }
);
app.MapGet("/about", () => "Contoso was founded in 2000.");

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

app.Run();
