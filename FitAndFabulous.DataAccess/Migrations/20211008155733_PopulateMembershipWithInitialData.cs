using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class PopulateMembershipWithInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Memberships(Name, Status, DateCreated, ExpiryDate, Description, PersonId, PackageId, AccessDaysId) Values('VIP Membership', 1, '10/8/2021', '12/10/2022', 'VIP members only', 2, 1, 4) ");

            migrationBuilder.Sql("INSERT INTO Memberships(Name, Status, DateCreated, ExpiryDate, Description, PersonId, PackageId, AccessDaysId) Values('REGULAR Membership', 2, '10/8/2021', '12/10/2025', 'REGULAR members only', 1008, 3, 2) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
