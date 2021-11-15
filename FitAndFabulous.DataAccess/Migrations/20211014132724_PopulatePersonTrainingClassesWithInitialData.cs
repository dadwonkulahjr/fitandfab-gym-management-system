using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulatePersonTrainingClassesWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(1, 1)");
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(1008, 2)");
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(2, 1)");
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(1009, 2)");
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(1010, 2)");
            migrationBuilder.Sql("INSERT INTO PersonTrainingClasses Values(1011, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
