using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentLevelID",
                table: "Students",
                newName: "StudentLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentLevelID",
                table: "Students",
                newName: "IX_Students_StudentLevelId");

            migrationBuilder.AlterColumn<long>(
                name: "StudentLevelId",
                table: "Students",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelId",
                table: "Students",
                column: "StudentLevelId",
                principalTable: "StudentLevels",
                principalColumn: "StudentLevelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentLevelId",
                table: "Students",
                newName: "StudentLevelID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentLevelId",
                table: "Students",
                newName: "IX_Students_StudentLevelID");

            migrationBuilder.AlterColumn<long>(
                name: "StudentLevelID",
                table: "Students",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelID",
                table: "Students",
                column: "StudentLevelID",
                principalTable: "StudentLevels",
                principalColumn: "StudentLevelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
