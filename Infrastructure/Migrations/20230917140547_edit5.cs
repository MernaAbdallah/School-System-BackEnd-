using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryTeacherCategoryID",
                table: "Teachers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers",
                column: "CategoryTeacherCategoryID",
                principalTable: "TeacherCategories",
                principalColumn: "TeacherCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers");

            migrationBuilder.AlterColumn<long>(
                name: "CategoryTeacherCategoryID",
                table: "Teachers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers",
                column: "CategoryTeacherCategoryID",
                principalTable: "TeacherCategories",
                principalColumn: "TeacherCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
