using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Verto_Tech_Test.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("5e798495-bf06-41f8-845c-8d0826cc97bb"), "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel.", "https://placehold.co/300x230", "New Products" },
                    { new Guid("8dde77e0-40e2-4487-8d1f-8cc7d605020d"), "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel.", "https://placehold.co/300x230", "Gallery" },
                    { new Guid("aae16c1b-164a-4ce0-a993-893b81ad2594"), "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel.", "https://placehold.co/300x230", "Field Events" },
                    { new Guid("d2ef780d-5415-447d-a283-ee0cd585f6d9"), "Lorem ipsum dolor sit amet, id per dictas inermis. Eam odio modo cibo at. Purto dignissim euripidis eu mel, cu mel.", "https://placehold.co/300x230", "Latest News" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: new Guid("5e798495-bf06-41f8-845c-8d0826cc97bb"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: new Guid("8dde77e0-40e2-4487-8d1f-8cc7d605020d"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: new Guid("aae16c1b-164a-4ce0-a993-893b81ad2594"));

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: new Guid("d2ef780d-5415-447d-a283-ee0cd585f6d9"));
        }
    }
}
