using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Color = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    IconCssClass = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    StockAmount = table.Column<byte>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategorysId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategorysId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    StarCount = table.Column<byte>(type: "INTEGER", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Color", "CreatedAt", "IconCssClass", "Name" },
                values: new object[,]
                {
                    { 1, "	#a4b2b0", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7920), null, "Yelek" },
                    { 2, "	#896863	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970), null, "Triko" },
                    { 3, "#C27D42	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970), null, "Sweatshirt" },
                    { 4, "	#BF8882	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970), null, "Şort" },
                    { 5, "	#A4B2B0	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970), null, "Kazak" },
                    { 6, "#828DE5", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980), null, "Elbise" },
                    { 7, "#595B56	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980), null, "Ceket" },
                    { 8, "	#CDC6C3	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980), null, "Pantolon" },
                    { 9, "#DEBDB0", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980), null, "Etek" },
                    { 10, "	#BE969B	", new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980), null, "Bluz" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Details", "Enabled", "IsConfirmed", "Name", "Price", "StockAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8030), "ürün açıklama", true, true, "Yelek 1", 619m, (byte)10 },
                    { 2, 1, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8040), "ürün açıklama", false, true, "Yelek 2", 619m, (byte)10 },
                    { 3, 1, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8040), "ürün açıklama", true, true, "Yelek 3", 510m, (byte)10 },
                    { 4, 2, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050), "ürün açıklama", true, true, "Triko 1", 700m, (byte)10 },
                    { 5, 2, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050), "ürün açıklama", false, true, "Triko 2", 700m, (byte)10 },
                    { 6, 2, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050), "ürün açıklama", false, true, "Triko 3", 700m, (byte)10 },
                    { 7, 3, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050), "ürün açıklama", true, true, "Sweatshirt 1", 320m, (byte)10 },
                    { 8, 3, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8060), "ürün açıklama", false, true, "Sweatshirt 2", 450m, (byte)10 },
                    { 9, 3, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8060), "ürün açıklama", true, true, "Sweatshirt 3", 600m, (byte)10 }
                });

            migrationBuilder.InsertData(
                table: "ProductComments",
                columns: new[] { "Id", "CreatedAt", "IsConfirmed", "ProductId", "StarCount", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080), true, 1, (byte)5, "Great product!" },
                    { 2, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080), true, 2, (byte)5, "Great product!" },
                    { 3, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080), true, 3, (byte)3, "Great product!" },
                    { 4, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080), true, 4, (byte)5, "Great product!" },
                    { 5, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080), true, 5, (byte)5, "Great product!" },
                    { 6, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8090), true, 6, (byte)1, "Great product!" },
                    { 7, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8090), true, 7, (byte)5, "Great product!" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8200), 1, "yelek-01.jpg" },
                    { 2, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8210), 2, "yelek-02.jpg" },
                    { 3, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8210), 3, "yelek-03.jpg" },
                    { 4, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220), 4, "triko-01.jpg" },
                    { 5, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220), 5, "triko-02.jpg" },
                    { 6, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220), 6, "triko-03.jpg" },
                    { 7, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230), 7, "sweatshirt-01.jpg" },
                    { 8, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230), 8, "sweatshirt-02.jpg" },
                    { 9, new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230), 9, "sweatshirt-03.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ProductId",
                table: "ProductComments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "ProductComments");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
