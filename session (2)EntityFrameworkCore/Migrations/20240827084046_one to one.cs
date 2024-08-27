using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session__2_EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class onetoone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmptId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmptId",
                table: "Departments",
                column: "EmptId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmptId",
                table: "Departments",
                column: "EmptId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmptId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmptId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EmptId",
                table: "Departments");
        }
    }
}
