using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewCari.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carihareketturu = table.Column<int>(type: "int", nullable: false),
                    MusteriIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemAdet = table.Column<short>(type: "smallint", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
