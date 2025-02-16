using AuctionService.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();


// Extensions
builder.Services.AddRabbitMqMassTransit();
builder.Services.AddMapsterConfiguration();
builder.Services.AddAuctionDbContextExtensionService(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
