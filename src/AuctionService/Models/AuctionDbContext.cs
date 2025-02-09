using AuctionService.Models.Entities.Auctions;
using AuctionService.Models.Entities.Items;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security;

namespace AuctionService.Models
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data to all entities
            //modelBuilder.Entity<Role>().HasData(RoleSeed.SeedData);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextOptions).Assembly);
        }
    }
}
