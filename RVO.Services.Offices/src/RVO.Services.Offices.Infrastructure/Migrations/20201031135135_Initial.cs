using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RVO.Services.Offices.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OfficeHours_SatTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_SatTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_SunTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_SunTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_MonTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_MonTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_TueTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_TueTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_WedTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_WedTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_ThuTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_ThuTimeRange_End = table.Column<DateTime>(nullable: true),
                    OfficeHours_FriTimeRange_Start = table.Column<DateTime>(nullable: true),
                    OfficeHours_FriTimeRange_End = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
