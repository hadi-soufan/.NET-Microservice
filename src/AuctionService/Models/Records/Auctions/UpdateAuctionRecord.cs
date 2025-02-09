namespace AuctionService.Models.Records.Auctions
{
    public sealed record UpdateAuctionRecord
    (
        Guid Id,
        string Make,
        string Model,
        int Year,
        string Color,
        int Mileage
    );
}
