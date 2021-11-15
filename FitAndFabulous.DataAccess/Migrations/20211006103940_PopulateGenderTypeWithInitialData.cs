using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateGenderTypeWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genders Values('Male', 'Gender of a Male.')");
            migrationBuilder.Sql("INSERT INTO Genders Values('Female', 'Gender of a Female.')");
            migrationBuilder.Sql("INSERT INTO Genders Values('Other', 'Gender of a Other.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
