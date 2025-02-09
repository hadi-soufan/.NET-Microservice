using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Models;
using SearchService.Models.Entities.Items;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseAuthorization();

app.MapControllers();

try
{
    await DbIntializer.InitDb(app);
}
catch (Exception ex)
{
    Console.WriteLine(ex);

}

app.Run();
