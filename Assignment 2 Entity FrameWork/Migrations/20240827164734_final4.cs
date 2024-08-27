using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_2_Entity_FrameWork.Migrations
{
    /// <inheritdoc />
    public partial class final4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "StudntId",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Stud_Course",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Stud_Course",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course",
                newName: "IX_Stud_Course_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Stud_Course",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Stud_Course",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_StudentId",
                table: "Stud_Course",
                newName: "IX_Stud_Course_StudentID");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Stud_Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Stud_Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Course",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudntId",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Course", "StudntId" });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID");
        }
    }
}
