using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateGymTypeWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Gyms Values('BodyZone Gym', 'Bodyzone Gym has over 3years of experienced in Liberia.', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('UNMIL Gym', 'UNMIL Gym has over 7years of experienced in Liberia', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('Roger and Cooper Fitness Gym', 'Roger and Cooper Fitness Center Gym has over 7years of experienced in Liberia.', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('YMCA ', 'YMCA Gym has over 10years of experienced in Liberia.', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('King Fitness', 'King Fitness Gym has over 3years of experienced.', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('Newport', 'Newport  Gym has over 3years of experienced.', 'null')");
            migrationBuilder.Sql("INSERT INTO Gyms Values('Baby Joe', 'Baby Joe Gym has over 3years of experienced.', 'null')");

              migrationBuilder.Sql("INSERT INTO Gyms Values('Liberia Table Tennis Association', 'Liberia Table Tennis Association has over 5years of experienced.', 'null')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
