using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamHolidayCalendarBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddLeavePlansTableToDbWithSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeavePlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavePlans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LeavePlans",
                columns: new[] { "Id", "EmployeeName", "LeaveEndDate", "LeaveReason", "LeaveStartDate" },
                values: new object[,]
                {
                    { new Guid("3b648d1d-32ae-48cb-ab0d-2bd79eea181c"), "Aslam", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("584d8d8c-e832-4366-abb4-957bea83fdfe"), "Rizwan", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b6203c8-8b3d-4717-b268-037f66e01ec6"), "Babar", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urgent Work", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70579101-c445-4af5-9e94-57287c214b90"), "Iftikhar", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7326f91-c5b3-434a-8011-29d5cee626ee"), "Azeem", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Appointment", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2d84115-ea51-4aaa-be40-09a45e5998d3"), "Jameel", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brother Marriage", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeavePlans");
        }
    }
}
