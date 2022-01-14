using CarutiFlix.Catalog.Domain.Entities;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",
		async () =>
		{
			var client = new MongoClient("mongodb://root:root@cf-mongo:27017/");
			var collection = client.GetDatabase("carutiflix-catalog");
			var categoryCollection = collection.GetCollection<Category>("Category");
			categoryCollection.InsertOne(new Category("Terror"));

			return Results.Ok(await categoryCollection.Find(x => x.Name.Equals("Terror")).ToListAsync());
		});

app.Run();