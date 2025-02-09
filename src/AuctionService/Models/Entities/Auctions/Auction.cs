using AuctionService.Models.Entities.Items;
using AuctionService.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Models.Entities.Auctions
{
    [Table("auction")]
    public class Auction : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("reservePrice")]
        public int ReservePrice { get; set; }

        [Required]
        [Column("seller")]
        public string Seller { get; set; }

        [Column("winner")]
        public string Winner { get; set; }

        [Column("sold_amount")]
        public int? SoldAmount { get; set; }

        [Column("current_high_bid")]
        public int? CurrentHighBid { get; set; }

        [Column("auction_end")]
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; }
        public Item Item { get; set; }
    }
}
