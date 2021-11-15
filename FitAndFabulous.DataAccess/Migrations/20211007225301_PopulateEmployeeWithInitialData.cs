using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateEmployeeWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Employees Values(1, '10/20/2005', 5000, 'tom@fitandfab.com')");

            migrationBuilder.Sql("INSERT INTO Employees Values(1009, '11/21/2001', 2450, 'john@fitandfab.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
