using Mapster;
using Contracts;
using SearchService.Models.Entities.Items;

namespace SearchService.RequestHelpers
{
    public class MappingProfiles : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuctionCreated, Item>()
                .Map(dest => dest.ID, src => src.Id.ToString()) 
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
