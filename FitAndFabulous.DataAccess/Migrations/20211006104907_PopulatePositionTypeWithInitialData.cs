using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulatePositionTypeWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Positions Values('Trainer')");
            migrationBuilder.Sql("INSERT INTO Positions Values('Manager')");
            migrationBuilder.Sql("INSERT INTO Positions Values('CEO')");
            migrationBuilder.Sql("INSERT INTO Positions Values('User')");
            migrationBuilder.Sql("INSERT INTO Positions Values('Agent')");
            migrationBuilder.Sql("INSERT INTO Positions Values('Employee')");
            migrationBuilder.Sql("INSERT INTO Positions Values('Member')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
