var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use( async(HttpContext context,RequestDelegate next) =>
      {
        await context.Response.WriteAsync("middleware 1" +"\n");

        await next(context);
    }
);

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("middleware 2");
}
);

app.Run();
