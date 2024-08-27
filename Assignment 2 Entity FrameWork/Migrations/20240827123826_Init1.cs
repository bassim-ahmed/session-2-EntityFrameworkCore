using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_2_Entity_FrameWork.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Course_ID", "stud_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Course_ID", "inst_ID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");
        }
    }
}
