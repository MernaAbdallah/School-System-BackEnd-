using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Managers_MangerManagerID",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_MangerManagerID",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "MangerManagerID",
                table: "Schools");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MangerManagerID",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_MangerManagerID",
                table: "Schools",
                column: "MangerManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Managers_MangerManagerID",
                table: "Schools",
                column: "MangerManagerID",
                principalTable: "Managers",
                principalColumn: "ManagerID");
        }
    }
}
