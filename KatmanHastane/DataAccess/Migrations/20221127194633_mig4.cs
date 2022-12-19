using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    hastane_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hastane_ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hastane_sehir = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.hastane_id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    login_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.login_ID);
                });

            migrationBuilder.CreateTable(
                name: "Policlinics",
                columns: table => new
                {
                    poliklinik_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    poliklinik_Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policlinics", x => x.poliklinik_ID);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    personel_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personel_Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personel_Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hastane_id = table.Column<int>(type: "int", nullable: true),
                    poliklinik_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.personel_ID);
                    table.ForeignKey(
                        name: "FK_Personals_Hospitals_hastane_id",
                        column: x => x.hastane_id,
                        principalTable: "Hospitals",
                        principalColumn: "hastane_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personals_Policlinics_poliklinik_ID",
                        column: x => x.poliklinik_ID,
                        principalTable: "Policlinics",
                        principalColumn: "poliklinik_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personals_hastane_id",
                table: "Personals",
                column: "hastane_id");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_poliklinik_ID",
                table: "Personals",
                column: "poliklinik_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Policlinics");
        }
    }
}
