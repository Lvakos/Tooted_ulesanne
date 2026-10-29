using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tooted.Migrations
{
    /// <inheritdoc />
    public partial class LisaOstukorv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ostukorv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasutajaId = table.Column<int>(type: "int", nullable: false),
                    ToodeId = table.Column<int>(type: "int", nullable: false),
                    Kogus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ostukorv", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ostukorv_Kasutajad_KasutajaId",
                        column: x => x.KasutajaId,
                        principalTable: "Kasutajad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ostukorv_Toodetabel_ToodeId",
                        column: x => x.ToodeId,
                        principalTable: "Toodetabel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ostukorv_KasutajaId_ToodeId",
                table: "Ostukorv",
                columns: new[] { "KasutajaId", "ToodeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ostukorv_ToodeId",
                table: "Ostukorv",
                column: "ToodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ostukorv");
        }
    }
}
