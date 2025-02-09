using AuctionService.Models.Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSys.App.Core.Constants;

namespace AuctionService.Models.Entities.Auctions
{
    public class AuctionConfiguration : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            // Table
            builder.ToTable("auction");


            // Properties
            builder.Property(a => a.Seller)
                .HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_50);

            builder.Property(a => a.Winner)
                .HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_50);

            // Relationship
            builder.HasOne(a => a.Item)
                .WithOne(i => i.Auction)
                .HasForeignKey<Item>(i => i.AuctionId);

            // Query Filter
            builder.HasQueryFilter(a => !a.IsDeleted);


            // Indexing for faster queries
            builder.HasIndex(a => a.Id);
            builder.HasIndex(a => a.Status);
        }
    }
}
