using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Section1:Add services to the container.
//all dependency related injection related  we need to write here
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Section2.Configure Http request pipeline.
var app = builder.Build();//This one request pipeline
//all middleware we need to configure/register /adding to this request pipeline
//whenever if you add any middleware to request pipeleine order wise it will exceute.
// middleware naming convention starts with use keyword.
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user9");
    await next.Invoke();//next will call the next middleware
});

app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user2");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user3");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user4");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user5");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user6");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user7");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user8");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user1");
    await next.Invoke();//next will call the next middleware
});
app.Run();
/*app.Run()
  is finally exceuted.finally app.run build the allmiddlewares and run the application.
  Without app.run() method application will not exceute.
*/