using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class Item : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNameId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCodeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSTId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSNCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MRPId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePriceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandingCostId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePriceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesDiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RackColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityWarning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMEnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemPackedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemManuDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemIssuedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
