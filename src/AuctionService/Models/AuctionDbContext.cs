using AuctionService.Models.Entities.Auctions;
using AuctionService.Models.Entities.Items;
using Microsoft.EntityFrameworkCore;

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContextOptions).Assembly);

            modelBuilder.Entity<Auction>().HasData(AuctionSeed.GetPreconfiguredAuctions());
            modelBuilder.Entity<Item>().HasData(ItemSeed.GetPreconfiguredItems());

            base.OnModelCreating(modelBuilder);

        }
    }
}
