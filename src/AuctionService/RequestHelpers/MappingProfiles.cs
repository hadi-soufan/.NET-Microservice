using AuctionService.Models.Entities.Auctions;
using AuctionService.Models.Entities.Items;
using AuctionService.Models.Enums;
using AuctionService.Models.Records.Auctions;
using Contracts;
using Mapster;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Auction, AuctionRecord>()
                .Map(dest => dest.Status, src => src.Status)
                .Map(dest => dest.Make, src => src.Item.Make)
                .Map(dest => dest.Model, src => src.Item.Model)
                .Map(dest => dest.Year, src => src.Item.Year)
                .Map(dest => dest.Color, src => src.Item.Color)
                .Map(dest => dest.Mileage, src => src.Item.Mileage)
                .Map(dest => dest.ImageUrl, src => src.Item.ImageUrl)
                .Map(dest => dest.CreatedAt, src => src.CreatedAt)
                .Map(dest => dest.UpdatedAt, src => src.UpdatedAt);

            config.NewConfig<CreateAuctionRecord, Auction>()
                .Map(dest => dest.Status, _ => Status.Live)
                .Map(dest => dest.Item, src => new Item
                {
                    Id = Guid.NewGuid(),
                    Make = src.Make,
                    Model = src.Model,
                    Year = src.Year,
                    Color = src.Color,
                    Mileage = src.Mileage,
                    ImageUrl = src.ImageUrl
                });

            config.NewConfig<AuctionRecord, AuctionCreated>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.ReservePrice, src => src.ReservePrice)
                .Map(dest => dest.Seller, src => src.Seller)
                .Map(dest => dest.Winner, src => src.Winner)
                .Map(dest => dest.SoldAmount, src => src.SoldAmount)
                .Map(dest => dest.CurrentHighBid, src => src.CurrentHighBid)
                .Map(dest => dest.AuctionEnd, src => src.AuctionEnd)
                .Map(dest => dest.Status, src => src.Status)
                .Map(dest => dest.Make, src => src.Make)
                .Map(dest => dest.Model, src => src.Model)
                .Map(dest => dest.Year, src => src.Year)
                .Map(dest => dest.Color, src => src.Color)
                .Map(dest => dest.Mileage, src => src.Mileage)
                .Map(dest => dest.ImageUrl, src => src.ImageUrl)
                .Map(dest => dest.CreatedAt, src => src.CreatedAt)
                .Map(dest => dest.UpdatedAt, src => src.UpdatedAt ?? src.CreatedAt); 
        }
    }
}
