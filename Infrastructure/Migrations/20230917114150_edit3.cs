using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MangerId",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_MangerId",
                table: "Schools",
                column: "MangerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Managers_MangerId",
                table: "Schools",
                column: "MangerId",
                principalTable: "Managers",
                principalColumn: "ManagerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Managers_MangerId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_MangerId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "MangerId",
                table: "Schools");
        }
    }
}
