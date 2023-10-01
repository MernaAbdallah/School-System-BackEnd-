using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editschooleid3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "SchoolID",
                table: "Teachers",
                newName: "SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SchoolID",
                table: "Teachers",
                newName: "IX_Teachers_SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "SchoolID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Teachers",
                newName: "SchoolID");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                newName: "IX_Teachers_SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID");
        }
    }
}
