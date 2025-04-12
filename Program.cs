//Learning DevOps process
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hello, DevOps!");

app.Run();
