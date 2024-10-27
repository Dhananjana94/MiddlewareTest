var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run( async(HttpContext context) =>
    {
        await context.Response.WriteAsync("middleware 1");
    }
);

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("middleware 2");
}
);

app.Run();
