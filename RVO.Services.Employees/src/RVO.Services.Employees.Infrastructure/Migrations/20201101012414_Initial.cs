using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RVO.Services.Employees.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OfficeId = table.Column<Guid>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    Discontinue = table.Column<bool>(nullable: false),
                    WeekSchedule_SatTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_SatTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_SunTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_SunTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_MonTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_MonTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_TueTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_TueTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_WedTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_WedTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_ThuTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_ThuTimeRange_End = table.Column<DateTime>(nullable: true),
                    WeekSchedule_FriTimeRange_Start = table.Column<DateTime>(nullable: true),
                    WeekSchedule_FriTimeRange_End = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
