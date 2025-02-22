﻿using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Models.Entities.Items;
using SearchService.Services;
using System.Text.Json;

namespace SearchService.Models
{
    public class DbIntializer
    {
        public static async Task InitDb(WebApplication app)
        {
            await DB.InitAsync("SearchDb", MongoClientSettings.FromConnectionString(app.Configuration.GetConnectionString("MongoDbConnection")));

            await DB.Index<Item>()
                .Key(i => i.Make, KeyType.Text)
                .Key(i => i.Model, KeyType.Text)
                .Key(i => i.Color, KeyType.Text)
                .CreateAsync();


            var count = await DB.CountAsync<Item>();
                
            using var scope = app.Services.CreateScope();

            var httpClient = scope.ServiceProvider.GetRequiredService<AuctionServiceHttpClient>();

            var items = await httpClient.GetItemsForSearchDb();

            Console.WriteLine(items.Count + " returned from auction service.");

            if (items.Count > 0) await DB.SaveAsync(items);
        }
    }
}
