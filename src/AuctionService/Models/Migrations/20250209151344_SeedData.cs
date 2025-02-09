using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuctionService.Models.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "winner",
                table: "auction",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "auction",
                columns: new[] { "id", "auction_end", "created_at", "current_high_bid", "is_deleted", "reservePrice", "seller", "sold_amount", "Status", "updated_at", "winner" },
                values: new object[,]
                {
                    { new Guid("155225c1-4448-4066-9886-6786536e05ea"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 50000, "tom", null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3659ac24-29dd-407a-81f5-ecfe6f924b9b"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 20000, "bob", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("40490065-dac7-46b6-acc4-df507e0d6570"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 20000, "tom", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("466e4744-4dc5-4987-aae0-b621acfc5e39"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 20000, "alice", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("47111973-d176-4feb-848d-0ea22641c31a"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 150000, "alice", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6a5011a1-fe1f-47df-9a32-b5346b289391"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 0, "bob", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("afbee524-5972-4075-8800-7d1f9d7b0a0c"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 20000, "bob", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 0, "bob", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 90000, "alice", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("dc1e4071-d19d-459b-b848-b5c3cd3d151f"), new DateTime(2025, 3, 1, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), null, false, 20000, "bob", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "auction_id", "color", "created_at", "image_url", "is_deleted", "make", "mileage", "model", "updated_at", "year" },
                values: new object[,]
                {
                    { new Guid("0741a60b-0873-4dad-af0b-ce523639205e"), new Guid("6a5011a1-fe1f-47df-9a32-b5346b289391"), "White", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2019/12/26/20/50/audi-r8-4721217_960_720.jpg", false, "Audi", 10050, "R8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2021 },
                    { new Guid("1a94e770-80cc-478b-a006-c5b5c1eb69c6"), new Guid("155225c1-4448-4066-9886-6786536e05ea"), "Silver", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2016/04/17/22/10/mercedes-benz-1335674_960_720.png", false, "Mercedes", 15001, "SLK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2020 },
                    { new Guid("2c2960f8-97b6-4b47-86f4-58e534e1d7a6"), new Guid("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"), "Black", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg", false, "Bugatti", 15035, "Veyron", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2018 },
                    { new Guid("351032f1-e736-47e4-9085-ce2a60ac4728"), new Guid("afbee524-5972-4075-8800-7d1f9d7b0a0c"), "White", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2016/05/06/16/32/car-1376190_960_720.jpg", false, "Ford", 50000, "GT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2020 },
                    { new Guid("62e36f6b-be60-4d16-bdaa-25e471870e7f"), new Guid("466e4744-4dc5-4987-aae0-b621acfc5e39"), "White", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2017/08/31/05/47/bmw-2699538_960_720.jpg", false, "BMW", 90000, "X1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2017 },
                    { new Guid("7e2c72fe-e882-40f8-a1ce-07711720ea59"), new Guid("3659ac24-29dd-407a-81f5-ecfe6f924b9b"), "Rust", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2017/08/02/19/47/vintage-2573090_960_720.jpg", false, "Ford", 150150, "Model T", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1938 },
                    { new Guid("9a74c1ab-5cd5-48da-9e07-4f145c0e6086"), new Guid("47111973-d176-4feb-848d-0ea22641c31a"), "Red", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2017/11/08/14/39/ferrari-f430-2930661_960_720.jpg", false, "Ferrari", 5000, "F-430", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2022 },
                    { new Guid("bc941cc7-5f29-4b16-b5eb-b0a8f79e5501"), new Guid("dc1e4071-d19d-459b-b848-b5c3cd3d151f"), "Red", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2017/11/09/01/49/ferrari-458-spider-2932191_960_720.jpg", false, "Ferrari", 50000, "Spider", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2015 },
                    { new Guid("cd5077f0-0ac9-48ed-86c2-e9265758c9bd"), new Guid("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"), "Black", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2012/11/02/13/02/car-63930_960_720.jpg", false, "Ford", 65125, "Mustang", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2023 },
                    { new Guid("fa069bbc-bb32-4846-903d-40a20ce1eb58"), new Guid("40490065-dac7-46b6-acc4-df507e0d6570"), "Black", new DateTime(2025, 2, 9, 12, 0, 0, 0, DateTimeKind.Utc), "https://cdn.pixabay.com/photo/2016/09/01/15/06/audi-1636320_960_720.jpg", false, "Audi", 25400, "TT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2020 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("0741a60b-0873-4dad-af0b-ce523639205e"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("1a94e770-80cc-478b-a006-c5b5c1eb69c6"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("2c2960f8-97b6-4b47-86f4-58e534e1d7a6"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("351032f1-e736-47e4-9085-ce2a60ac4728"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("62e36f6b-be60-4d16-bdaa-25e471870e7f"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("7e2c72fe-e882-40f8-a1ce-07711720ea59"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("9a74c1ab-5cd5-48da-9e07-4f145c0e6086"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("bc941cc7-5f29-4b16-b5eb-b0a8f79e5501"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("cd5077f0-0ac9-48ed-86c2-e9265758c9bd"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("fa069bbc-bb32-4846-903d-40a20ce1eb58"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("155225c1-4448-4066-9886-6786536e05ea"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("3659ac24-29dd-407a-81f5-ecfe6f924b9b"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("40490065-dac7-46b6-acc4-df507e0d6570"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("466e4744-4dc5-4987-aae0-b621acfc5e39"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("47111973-d176-4feb-848d-0ea22641c31a"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("6a5011a1-fe1f-47df-9a32-b5346b289391"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("afbee524-5972-4075-8800-7d1f9d7b0a0c"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"));

            migrationBuilder.DeleteData(
                table: "auction",
                keyColumn: "id",
                keyValue: new Guid("dc1e4071-d19d-459b-b848-b5c3cd3d151f"));

            migrationBuilder.AlterColumn<string>(
                name: "winner",
                table: "auction",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
