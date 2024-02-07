using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class Sale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B2BInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B2CInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Particular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Itemcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePrize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePrize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cgst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sgst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
