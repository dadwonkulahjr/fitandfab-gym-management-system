using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateMemberWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Members Values(2, 'We go one member.', 13)");
            migrationBuilder.Sql("INSERT INTO Members Values(1008, 'We go one member.', 19)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
