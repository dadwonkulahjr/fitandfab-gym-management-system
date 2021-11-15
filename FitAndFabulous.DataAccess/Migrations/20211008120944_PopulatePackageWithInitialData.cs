using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulatePackageWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Packages(Name,Amount,Description) Values('VIP', 150, 'Daily access to gym FREE Sauna Access 20% Discount on spa services 3 guest passes every registration FREE early bird classes')");

            migrationBuilder.Sql("INSERT INTO Packages(Name,Amount,Description) Values('VIP', 130, 'Daily, No services. FREE early bird classes')");


            migrationBuilder.Sql("INSERT INTO Packages(Name,Amount,Description) Values('REGULAR', 100, '4 times a week FREE early bird classes')");

            migrationBuilder.Sql("INSERT INTO Packages(Name,Amount,Description) Values('COUPLES', 180, '4 times a week Male & Female FREE early bird classes')");

            migrationBuilder.Sql("INSERT INTO Packages(Name,Amount,Description) Values('GYM SPECIAL', 75, '6am to 9am daily FREE early bird classes')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
