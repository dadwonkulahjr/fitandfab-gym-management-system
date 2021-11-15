using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateDaysWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Sunday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Monday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Tuesday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Wednesday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Thursday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Friday')");
            migrationBuilder.Sql("INSERT INTO Days(Name) Values('Saturaday')");
        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
