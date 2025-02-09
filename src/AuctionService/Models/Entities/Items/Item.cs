using AuctionService.Models.Entities.Auctions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Models.Entities.Items
{
    [Table("item")]
    public class Item : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("auction_id")]
        public Guid AuctionId { get; set; }

        [Required]
        [Column("make")]
        public string Make { get; set; }

        [Required]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [Column("year")]
        public int Year { get; set; }

        [Required]
        [Column("color")]
        public string Color { get; set; }

        [ForeignKey("AuctionId")]
        public Auction Auction { get; set; }
    }
}
