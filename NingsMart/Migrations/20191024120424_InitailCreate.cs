using Microsoft.EntityFrameworkCore.Migrations;

namespace NingsMart.Migrations
{
    public partial class InitailCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productTble",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", nullable: true),
                    nvarchar100 = table.Column<int>(name: "nvarchar(100)", nullable: false),
                    nvarcharmax = table.Column<int>(name: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTble", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productTble");
        }
    }
}
