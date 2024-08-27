using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_2_Entity_FrameWork.Migrations
{
    /// <inheritdoc />
    public partial class Init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stud_ID",
                table: "Stud_Course",
                newName: "StudntID");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Stud_Course",
                newName: "CourseID");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Stud_Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_Id",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_ID",
                table: "Course",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course",
                column: "Top_ID",
                principalTable: "Topic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_ID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "StudntID",
                table: "Stud_Course",
                newName: "stud_ID");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Stud_Course",
                newName: "Course_ID");
        }
    }
}
