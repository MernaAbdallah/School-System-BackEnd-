using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editschooleid12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID1",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherID1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherID1",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Teachers",
                newName: "SchoolID");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                newName: "IX_Teachers_SchoolID");

            migrationBuilder.AlterColumn<long>(
                name: "SchoolID",
                table: "Teachers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolID",
                table: "Students",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "SchoolID",
                table: "Teachers",
                newName: "SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SchoolID",
                table: "Teachers",
                newName: "IX_Teachers_SchoolId");

            migrationBuilder.AlterColumn<long>(
                name: "SchoolId",
                table: "Teachers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "Teachers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TeacherID1",
                table: "Courses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId",
                unique: true,
                filter: "[CourseId] IS NOT NULL");

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
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolID",
                table: "Students",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
