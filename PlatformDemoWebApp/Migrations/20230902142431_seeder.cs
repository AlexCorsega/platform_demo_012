using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Alice", "09202535208" },
                    { 2, "Bob", "09857360608" },
                    { 3, "Charlie", "09666813985" },
                    { 4, "David", "09669788047" },
                    { 5, "Ella", "09262812603" },
                    { 6, "Frank", "09401388259" },
                    { 7, "Grace", "09705412539" },
                    { 8, "Hannah", "09205729248" },
                    { 9, "Isaac", "09321675762" },
                    { 10, "Julia", "09922937263" },
                    { 11, "Karl", "09455051349" },
                    { 12, "Lily", "09271307752" },
                    { 13, "Michael", "09469726943" },
                    { 14, "Nora", "09913819504" },
                    { 15, "Oliver", "09283295962" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { 28, 423557.0, 3, "e7237389-4923-45db-b915-a725bf1e8a15" },
                    { 33, 176577.0, 6, "582efbf7-031a-478d-ae0c-b359e146c16f" },
                    { 85, 367006.0, 4, "95b9a2c3-8479-4254-ac11-3b2aa98e67d3" },
                    { 243, 92975.0, 10, "6a6ff05a-4b83-4841-a042-0962d5850517" },
                    { 254, 417594.0, 15, "996cd705-11a0-4cdc-9217-0da004cd615f" },
                    { 256, 487206.0, 8, "cb620be4-a92b-4289-80ab-8f216f6c69f3" },
                    { 259, 447155.0, 11, "ecab4b47-dccd-4cac-ba55-494b29724900" },
                    { 282, 267673.0, 8, "732777d3-01d3-42c9-9148-cb116aaa9dc0" },
                    { 304, 431966.0, 14, "53bb440f-a697-4643-8af7-9619869d0454" },
                    { 321, 264037.0, 13, "c4779e9c-8674-4da2-95a2-59089d4b9a6a" },
                    { 326, 424462.0, 6, "be28efe7-5654-42e7-9e30-79f5c741b789" },
                    { 336, 135573.0, 12, "074725c3-a0b1-49f3-84b8-53cb245a5fa8" },
                    { 345, 122025.0, 4, "6e576388-1b08-4ca9-89ec-7f1475225fbb" },
                    { 440, 276142.0, 15, "cb23a98c-5c39-4392-8253-a4fd5aa739d8" },
                    { 446, 468012.0, 10, "1bae75c5-cbe7-4667-8273-5dbe477907eb" },
                    { 453, 370433.0, 14, "251dc470-ddf6-41a2-9034-bccc0a1b7291" },
                    { 480, 83431.0, 12, "22558757-e726-4438-96c4-924a7142f531" },
                    { 494, 375391.0, 14, "f4eb081d-d953-4ba2-b106-7a0235fc0ad5" },
                    { 521, 318027.0, 2, "2bb497f4-d8db-41ea-b6e7-cbb1a7222a14" },
                    { 575, 232072.0, 3, "fe37a7a5-3f3f-44cf-a048-d4786e0fb1f3" },
                    { 586, 169921.0, 3, "21bc3a9d-db29-4fa4-808c-8ca440283af4" },
                    { 593, 109045.0, 13, "d815a439-60fe-40ce-9366-f5e62b01b5ed" },
                    { 607, 402410.0, 12, "99b71fc2-dbdd-451c-989a-dda8095d3edd" },
                    { 608, 232560.0, 10, "072311bc-4145-4ab3-b20b-08d18b32b370" },
                    { 611, 95860.0, 13, "d3136d04-bfe4-457c-9421-90525026d0ad" },
                    { 630, 190705.0, 11, "1b25f9cd-5125-4ea5-80f7-e53734bb9602" },
                    { 632, 496812.0, 13, "55416328-0054-4c72-8b23-fa8a4a90d1eb" },
                    { 639, 195919.0, 12, "305a1d14-a2b4-45aa-bc34-730fd18fc264" },
                    { 661, 310415.0, 5, "adb1ea73-d485-41cf-a6ae-5d87dc3777cd" },
                    { 663, 43423.0, 15, "d682d744-e4e7-4fe1-873b-42a07388fec3" },
                    { 676, 123262.0, 10, "ade4ba23-1962-4833-83b4-a75d892bb5a7" },
                    { 683, 490513.0, 7, "60a987af-f32a-4619-98e7-e5ad9ccd874f" },
                    { 709, 309174.0, 5, "844e85c4-45d4-425c-bac0-b14f68e411e6" },
                    { 737, 168254.0, 11, "6878489b-4b2e-40ad-974b-f2a2a28a2dc9" },
                    { 738, 372193.0, 3, "6aa10a30-9614-4ca6-9de4-f5352f7ff210" },
                    { 784, 112854.0, 4, "db2701d3-e46b-4b54-888d-1c530eeccb62" },
                    { 885, 95663.0, 6, "61468e1f-9d4b-417a-8b1f-3e9d5a427b97" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 15);
        }
    }
}
