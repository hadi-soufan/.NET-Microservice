using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProSys.App.Core.Constants;

namespace AuctionService.Models.Entities.Items
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            // Table
            builder.ToTable("item");

            // Properties
            builder.Property(i => i.Make)
                .HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_35);

            builder.Property(i => i.Model)
                .HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_35);

            builder.Property(i => i.Color)
                .HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_35);

            builder.Property(i => i.ImageUrl)
                .HasColumnType("text");

            // Relations
            builder.HasOne(i => i.Auction)
                .WithOne(a => a.Item)
                .HasForeignKey<Item>(i => i.AuctionId);

            // Query Filter
            builder.HasQueryFilter(i => !i.IsDeleted);

            // Indexing
            builder.HasIndex(i => i.Make);
            builder.HasIndex(i => i.Model);
        }
    }
}
