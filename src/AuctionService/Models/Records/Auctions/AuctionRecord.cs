namespace AuctionService.Models.Records.Auctions
{
    public sealed record AuctionRecord
    (
        Guid Id,
        int ReservePrice,
        string Seller,
        string Winner,
        int? SoldAmount,
        int? CurrentHighBid,
        DateTime AuctionEnd,
        string Status,
        string Make,
        string Model,
        int Year,
        string Color,
        int Mileage,
        string ImageUrl,
        DateTime CreatedAt,
        DateTime? UpdatedAt
    );
}
