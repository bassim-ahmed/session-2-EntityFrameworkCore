using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_2_Entity_FrameWork.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "StudntID",
                table: "Stud_Course",
                newName: "StudntId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
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

            migrationBuilder.RenameColumn(
                name: "StudntId",
                table: "Stud_Course",
                newName: "StudntID");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
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
                columns: new[] { "CourseID", "StudntID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
