using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateAccessDaysWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AccessDays(Date, Time) Values('10/8/2021', '03:50:59')");
            migrationBuilder.Sql("INSERT INTO AccessDays(Date, Time) Values('10/20/2021', '10:12:19')");
            migrationBuilder.Sql("INSERT INTO AccessDays(Date, Time) Values('11/10/2021', '05:10:20')");
            migrationBuilder.Sql("INSERT INTO AccessDays(Date, Time) Values('12/23/2021', '04:54:22')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
