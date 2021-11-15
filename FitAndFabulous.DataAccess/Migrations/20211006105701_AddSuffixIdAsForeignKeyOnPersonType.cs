using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class AddSuffixIdAsForeignKeyOnPersonType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuffixId",
                table: "Persons",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PositionId",
                table: "Persons",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Positions_PositionId",
                table: "Persons",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Positions_PositionId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PositionId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SuffixId",
                table: "Persons");
        }
    }
}
