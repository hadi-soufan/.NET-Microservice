using System.ComponentModel.DataAnnotations;

namespace AuctionService.Models.Records.Auctions
{
    public sealed record CreateAuctionRecord
    (
        int ReservePrice,
        DateTime AuctionEnd,
        string Make,
        string Model,
        int Year,
        string Color,
        int Mileage,
        string ImageUrl
    );
}
