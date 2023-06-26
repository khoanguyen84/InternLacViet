using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Student_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FullName", "GradeId" },
                values: new object[,]
                {
                    { 3, "luong@gmail.com", "Lượng Nguyễn", 1 },
                    { 4, "thien@gmail.com", "Thiện Nguyễn", 2 },
                    { 5, "duy@gmail.com", "Duy Nguyễn", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);
        }
    }
}
