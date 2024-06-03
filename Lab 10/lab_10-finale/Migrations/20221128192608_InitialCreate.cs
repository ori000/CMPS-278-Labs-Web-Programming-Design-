using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab_10_finale_ori00.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    rooms = table.Column<int>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    location = table.Column<string>(type: "TEXT", nullable: false),
                    phone = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<int>(type: "INTEGER", nullable: false),
                    imgURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.name);
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "name", "description", "imgURL", "location", "phone", "rating", "rooms" },
                values: new object[] { "Hotel_1", "D1", "", "Beirut", "1921", 4, 100 });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "name", "description", "imgURL", "location", "phone", "rating", "rooms" },
                values: new object[] { "Hotel_2", "D2", "", "Jaffa", "2121", 5, 200 });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "name", "description", "imgURL", "location", "phone", "rating", "rooms" },
                values: new object[] { "Hotel_3", "D3", "", "Nicosia", "3221", 5, 220 });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "name", "description", "imgURL", "location", "phone", "rating", "rooms" },
                values: new object[] { "Hotel_4", "D4", "", "Alexandria", "2221", 5, 420 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
