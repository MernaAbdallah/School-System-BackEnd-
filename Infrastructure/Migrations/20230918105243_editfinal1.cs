using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editfinal1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "CategoryTeacherCategoryID",
                table: "Teachers",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_CategoryTeacherCategoryID",
                table: "Teachers",
                newName: "IX_Teachers_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryId",
                table: "Teachers",
                column: "CategoryId",
                principalTable: "TeacherCategories",
                principalColumn: "TeacherCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryId",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Teachers",
                newName: "CategoryTeacherCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_CategoryId",
                table: "Teachers",
                newName: "IX_Teachers_CategoryTeacherCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherCategories_CategoryTeacherCategoryID",
                table: "Teachers",
                column: "CategoryTeacherCategoryID",
                principalTable: "TeacherCategories",
                principalColumn: "TeacherCategoryID");
        }
    }
}
