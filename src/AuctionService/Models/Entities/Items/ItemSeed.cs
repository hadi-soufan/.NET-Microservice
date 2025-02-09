namespace AuctionService.Models.Entities.Items
{
    public static class ItemSeed
    {
        public static List<Item> GetPreconfiguredItems() =>
        [
             new Item
             {
                Id = Guid.Parse("351032F1-E736-47E4-9085-CE2A60AC4728"),
                AuctionId = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Make = "Ford",
                Model = "GT",
                Color = "White",
                Mileage = 50000,
                Year = 2020,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/05/06/16/32/car-1376190_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
             },
            new Item
            {
                Id = Guid.Parse("2C2960F8-97B6-4B47-86F4-58E534E1D7A6"),
                AuctionId = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Make = "Bugatti",
                Model = "Veyron",
                Color = "Black",
                Mileage = 15035,
                Year = 2018,
                ImageUrl = "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("CD5077F0-0AC9-48ED-86C2-E9265758C9BD"),
                AuctionId = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Make = "Ford",
                Model = "Mustang",
                Color = "Black",
                Mileage = 65125,
                Year = 2023,
                ImageUrl = "https://cdn.pixabay.com/photo/2012/11/02/13/02/car-63930_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("1A94E770-80CC-478B-A006-C5B5C1EB69C6"),
                AuctionId = Guid.Parse("155225c1-4448-4066-9886-6786536e05ea"),
                Make = "Mercedes",
                Model = "SLK",
                Color = "Silver",
                Mileage = 15001,
                Year = 2020,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/04/17/22/10/mercedes-benz-1335674_960_720.png",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
             },
            new Item
            {
                Id = Guid.Parse("62E36F6B-BE60-4D16-BDAA-25E471870E7F"),
                AuctionId = Guid.Parse("466e4744-4dc5-4987-aae0-b621acfc5e39"),
                Make = "BMW",
                Model = "X1",
                Color = "White",
                Mileage = 90000,
                Year = 2017,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/08/31/05/47/bmw-2699538_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("BC941CC7-5F29-4B16-B5EB-B0A8F79E5501"),
                AuctionId = Guid.Parse("dc1e4071-d19d-459b-b848-b5c3cd3d151f"),
                Make = "Ferrari",
                Model = "Spider",
                Color = "Red",
                Mileage = 50000,
                Year = 2015,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/11/09/01/49/ferrari-458-spider-2932191_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("9A74C1AB-5CD5-48DA-9E07-4F145C0E6086"),
                AuctionId = Guid.Parse("47111973-d176-4feb-848d-0ea22641c31a"),
                Make = "Ferrari",
                Model = "F-430",
                Color = "Red",
                Mileage = 5000,
                Year = 2022,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/11/08/14/39/ferrari-f430-2930661_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("0741A60B-0873-4DAD-AF0B-CE523639205E"),
                AuctionId = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346b289391"),
                Make = "Audi",
                Model = "R8",
                Color = "White",
                Mileage = 10050,
                Year = 2021,
                ImageUrl = "https://cdn.pixabay.com/photo/2019/12/26/20/50/audi-r8-4721217_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("FA069BBC-BB32-4846-903D-40A20CE1EB58"),
                AuctionId = Guid.Parse("40490065-dac7-46b6-acc4-df507e0d6570"),
                Make = "Audi",
                Model = "TT",
                Color = "Black",
                Mileage = 25400,
                Year = 2020,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/01/15/06/audi-1636320_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            },
            new Item
            {
                Id = Guid.Parse("7E2C72FE-E882-40F8-A1CE-07711720EA59"),
                AuctionId = Guid.Parse("3659ac24-29dd-407a-81f5-ecfe6f924b9b"),
                Make = "Ford",
                Model = "Model T",
                Color = "Rust",
                Mileage = 150150,
                Year = 1938,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/08/02/19/47/vintage-2573090_960_720.jpg",
                CreatedAt = new DateTime(2025, 02, 09, 12, 00, 00, DateTimeKind.Utc)
            }
        ];
    }
}






