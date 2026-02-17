using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use(async (context, next) =>
{
    await next();
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
});
app.MapGet("/", () => "Welcome to Contoso!");
app.MapGet("/about", () => "Contoso was founded in 2000.");

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

app.Run();
