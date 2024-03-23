using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagment.Data.Migrations
{
    /// <inheritdoc />
    public partial class loli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83033042-faab-4d93-906f-33516491bedd", "AQAAAAIAAYagAAAAECvoQpmI645dnvGIcoaskMXMadu6C1hEC9C2M1LgxuJHjLGQ6OySMq6XDr+BHPRi3w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ee35b1d-0686-4a41-9aff-98fba45da46f", "AQAAAAIAAYagAAAAEKFUB5B50BVfCKwBhA74PZUPJHsojpZn/gXI6ro3qi/xpgb7VWaHOUt19OGrNxtxsA==" });
        }
    }
}
