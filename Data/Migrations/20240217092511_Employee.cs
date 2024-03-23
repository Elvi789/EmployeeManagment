using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagment.Data.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ee35b1d-0686-4a41-9aff-98fba45da46f", "AQAAAAIAAYagAAAAEKFUB5B50BVfCKwBhA74PZUPJHsojpZn/gXI6ro3qi/xpgb7VWaHOUt19OGrNxtxsA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06f7727d-5761-4527-a7c9-eefdc4ecd679", "AQAAAAIAAYagAAAAEMHMBzkIDuyhKV2uxKxoW9M5UJ5sUK8dSN6WTFwUnw0lLLpQe33V7qq1KDlrTeDDAg==" });
        }
    }
}
