using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrMenuDataAccessLayer.Migrations
{
    public partial class mig_add_slider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    sliderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.sliderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
