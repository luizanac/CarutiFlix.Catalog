var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",
		() =>
		{
			var debugPoint = 10;
			return debugPoint;
		});

app.Run();