using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateTrainingClassWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TrainingClasses(Name,Time,DayId) Values('Regular Class', '5:30', 7)");
            migrationBuilder.Sql("INSERT INTO TrainingClasses(Name,Time,DayId) Values('VIP Class', '4:30', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
