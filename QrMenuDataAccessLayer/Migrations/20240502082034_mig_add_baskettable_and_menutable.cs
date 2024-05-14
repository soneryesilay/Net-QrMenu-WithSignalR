using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrMenuDataAccessLayer.Migrations
{
    public partial class mig_add_baskettable_and_menutable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tableNumber",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "menuTableID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tableID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    basketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: false),
                    MenuTableID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.basketID);
                    table.ForeignKey(
                        name: "FK_Baskets_MenuTables_MenuTableID",
                        column: x => x.MenuTableID,
                        principalTable: "MenuTables",
                        principalColumn: "menuTableID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_menuTableID",
                table: "Orders",
                column: "menuTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_MenuTableID",
                table: "Baskets",
                column: "MenuTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_productID",
                table: "Baskets",
                column: "productID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_MenuTables_menuTableID",
                table: "Orders",
                column: "menuTableID",
                principalTable: "MenuTables",
                principalColumn: "menuTableID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_MenuTables_menuTableID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Orders_menuTableID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "menuTableID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "tableID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "tableNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
