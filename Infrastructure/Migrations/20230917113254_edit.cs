using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Managers_MangerId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_MangerId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MangerId",
                table: "Schools");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Courses",
                newName: "TeacherId");

            migrationBuilder.AddColumn<long>(
                name: "MangerManagerID",
                table: "Schools",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TeacherId",
                table: "Courses",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "TeacherID1",
                table: "Courses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_MangerManagerID",
                table: "Schools",
                column: "MangerManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID1",
                table: "Courses",
                column: "TeacherID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID1",
                table: "Courses",
                column: "TeacherID1",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Managers_MangerManagerID",
                table: "Schools",
                column: "MangerManagerID",
                principalTable: "Managers",
                principalColumn: "ManagerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID1",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Managers_MangerManagerID",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_MangerManagerID",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherID1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MangerManagerID",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "TeacherID1",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Courses",
                newName: "TeacherID");

            migrationBuilder.AddColumn<long>(
                name: "MangerId",
                table: "Schools",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "TeacherID",
                table: "Courses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_MangerId",
                table: "Schools",
                column: "MangerId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                column: "TeacherID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Managers_MangerId",
                table: "Schools",
                column: "MangerId",
                principalTable: "Managers",
                principalColumn: "ManagerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
